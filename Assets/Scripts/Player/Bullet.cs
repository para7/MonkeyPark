using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Park.Player
{
    public class Bullet : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {

        }

        public float speed = 50f;
        public float lifetime = 0.3f;
        private float time = 0;
        public float fallSpeed = -0.3f;
        public float shake = 0.1f;
        public float dashShake = 0.8f;

        private Vector3 randomSpd;

        private void Awake()
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

        // Update is called once per frame
        void FixedUpdate()
        {
            this.transform.position += this.transform.forward * Time.deltaTime * speed + randomSpd;

            time += Time.deltaTime;

            if (time > lifetime / 2)
            {
                speed *= 0.95f;
                transform.position += new Vector3(0, fallSpeed, 0);
            }

            if (time > lifetime)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
