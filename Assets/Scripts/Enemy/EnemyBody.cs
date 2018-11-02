using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Park.Player;
using UniRx;
using System;

namespace Park.Enemy
{
    public class EnemyBody : MonoBehaviour
    {
        public float hp = 5.9f;
        private bool isDead = false;
        private Vector3 flyingSpeed;
        private Spawn spawn;

        // Use this for initialization
        void Start()
        {
            spawn = GetComponentInParent<Spawn>();
        }

        //吹き飛びを設定
        void SetFlying()
        {
            flyingSpeed = transform.forward;
            flyingSpeed.y = 2f;
        }

        // Update is called once per frame
        void Update()
        {
            if (sestate != SeState.nose)
            {
                if (sestate == SeState.headse)
                {
                    headhistse.Play();
                }
                else if (sestate == SeState.nomalse)
                {
                    hitse.Play();
                }

                sestate = SeState.nose;
            }

            if (isDead)
            {
                //吹き飛び移動
                transform.position += flyingSpeed * Time.deltaTime * 28f;
                flyingSpeed.y -= Time.deltaTime * 9f;
                transform.localEulerAngles += new Vector3(0, 0, Time.deltaTime * 1100f);
            }
            else if (hp < 0)
            {
                isDead = true;
                SetFlying();
                GetComponentInParent<LookCamera>().enabled = false;
                GetComponentInParent<EnemyMove>().OnDead();
                //スコア加算
                ScoreSystem.score += 100;
            }
        }

        public AudioSource hitse, headhistse;

        enum SeState
        {
            nose, nomalse, headse
        };

        SeState sestate;

        private void OnTriggerEnter(Collider other)
        {
            var bullet = other.gameObject.GetComponent<Bullet>();
            if (bullet == null)
            {
                return;
            }

            if (sestate != SeState.headse)
            {
                sestate = SeState.nomalse;
            }
            other.gameObject.GetComponent<Bullet>().OnHit();

            hp -= 1;
        }


        public void OnHeadShot()
        {
            sestate = SeState.headse;

            hp -= 2.5f;
        }

        private void OnDestroy()
        {
            spawn.isUsing = false;
        }
    }
}
