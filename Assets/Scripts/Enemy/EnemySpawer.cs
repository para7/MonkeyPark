using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Park.Enemy
{
    public class EnemySpawer : MonoBehaviour
    {
        struct Minmax
        {
            public float min;
            public float max;
        }

        Minmax xrange, zrange;

        public GameObject[] Enemys;

        // Use this for initialization
        void Start()
        {
            foreach (var v in GetComponent<MeshFilter>().mesh.vertices)
            {
                xrange.max = Mathf.Max(v.x, xrange.max);
                xrange.min = Mathf.Min(v.x, xrange.min);
                zrange.max = Mathf.Max(v.x, zrange.max);
                zrange.min = Mathf.Min(v.x, zrange.min);
            }


        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}