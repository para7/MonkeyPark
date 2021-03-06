﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Park.Player
{
    public class Bullet : MonoBehaviour
    {
        public float speed = 50f;
        public float lifetime = 0.3f;
        private float time = 0;
        public float fallSpeed = -0.3f;
        public float shake = 0.1f;
        public float dashShake = 0.8f;
        public float speedadj = 0.75f;

        private Vector3 randomSpd;

        private void Start()
        {
            speed += Random.Range(-speed / 20f, speed / 20f);

            //ブレ変数
            float random = 0;

            if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.01f || Mathf.Abs(Input.GetAxis("Vertical")) > 0.01f)
            {
                random = Input.GetKey(KeyCode.LeftShift) ? dashShake : shake;
            }

            randomSpd = new Vector3(Random.Range(-random, random), Random.Range(-random, random), Random.Range(-random, random));
        }

        void FixedUpdate()
        {
            time += Time.deltaTime;

            if (time > lifetime)
            {
                Destroy(this.gameObject);

                return;
            }

            //弾が進む
            this.transform.position += this.transform.forward * Time.deltaTime * speed + randomSpd;

            //時間減速
            if (time > lifetime / 2)
            {
                speed *= speedadj;
                transform.position += new Vector3(0, fallSpeed, 0);
            }
        }

        public void OnHit()
        {
            lifetime = 0;
        }
    }
}
