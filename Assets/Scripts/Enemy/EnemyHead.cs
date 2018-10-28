using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Park.Enemy
{
    public class EnemyHead : MonoBehaviour
    {
        EnemyBody body;

        // Use this for initialization
        void Start()
        {
            body = GetComponent<EnemyBody>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            var bullet = other.gameObject.GetComponent<Player.Bullet>();

            if (bullet == null)
            {
                return;
            }

            Debug.Log("HeadShot");

            other.gameObject.GetComponent<Player.Bullet>().OnHit();
        }
    }
}