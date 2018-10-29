using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Park.Score;

namespace Park.Enemy
{
    public class EnemyServer : MonoBehaviour
    {
        private Spawn[] spawns;

        // Use this for initialization
        void Start()
        {
            spawns = GetComponentsInChildren<Spawn>();
        }

        // Update is called once per frame
        void Update()
        {
            if(Random.Range(0f, 100f) < DifficlutySystem.difficulty)
            {

            }
        }
    }
}