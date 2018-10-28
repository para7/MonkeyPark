using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Park.Player
{
    public class Shoot : MonoBehaviour
    {
        public GameObject bullet;

        public float shootcool = 0.15f;

        float cool = 0f;

        public float shotGenelateRange = 1f;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            cool -= Time.deltaTime;

            if (Input.GetAxis("Fire1") > 0.1 && cool < 0)
            {
                var b = Instantiate(bullet);
                b.transform.rotation = this.transform.rotation;
                b.transform.position = this.transform.position + (-b.transform.up) * shotGenelateRange;

                cool = shootcool;
            }
        }
    }
}