using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Park.Player;

namespace Park.Enemy
{
    public class EnemyBody : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            var bullet = other.gameObject.GetComponent<Bullet>();
            if (bullet == null)
            {
                return;
            }

            Debug.Log("Hit");

            //other.gameObject.GetComponent<Bullet>().OnHit();
        }


        public void OnHeadShot()
        {

        }
    }
}
