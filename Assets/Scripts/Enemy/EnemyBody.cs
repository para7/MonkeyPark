using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Park.Player;

namespace Park.Enemy
{
    public class EnemyBody : MonoBehaviour
    {
        public float hp = 5.9f;
        private bool isDead = false;
        private Vector3 flyingSpeed;

        // Use this for initialization
        void Start()
        {

        }

        //吹き飛びを設定
        void SetFlying()
        {
            flyingSpeed = transform.forward;
            flyingSpeed.y = 1.7f;
        }

        // Update is called once per frame
        void Update()
        {
            if (isDead)
            {
                //吹き飛び
                transform.position += flyingSpeed * Time.deltaTime * 28f;
                flyingSpeed.y -= Time.deltaTime * 9f;
                transform.localEulerAngles += new Vector3(0,0, Time.deltaTime * 1100f);
            }
            else if (hp < 0)
            {
                isDead = true;
                SetFlying();
                GetComponentInParent<LookCamera>().enabled = false;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            var bullet = other.gameObject.GetComponent<Bullet>();
            if (bullet == null)
            {
                return;
            }

            other.gameObject.GetComponent<Bullet>().OnHit();

            hp -= 1;
        }


        public void OnHeadShot()
        {
            hp -= 5.0f;
        }
    }
}
