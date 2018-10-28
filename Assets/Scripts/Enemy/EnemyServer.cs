using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Park.Enemy
{
    public class EnemyServer : MonoBehaviour
    {
        private Vector3[] spawns;

        // Use this for initialization
        void Start()
        {
            spawns = GetComponentsInChildren<Spawn>().Select(x => x.transform.position).ToArray();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}