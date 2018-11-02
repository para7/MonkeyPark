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

        [SerializeField] GameObject[] enemys;

        // Use this for initialization
        void Start()
        {
            spawns = GetComponentsInChildren<Spawn>();
        }

        private float spawnable = 0f;

        public float spawncool = 0.2f;

        // Update is called once per frame
        void FixedUpdate()
        {
            spawnable += Time.fixedDeltaTime;

            if(spawnable > spawncool && Random.Range(0f, 100f) < DifficlutySystem.difficulty)
            {
                for (int i = 0; i < 10; ++i)
                {
                    int index = Random.Range(0, spawns.Length - 1);

                    if(spawns[index].isUsing)
                    {
                        continue;
                    }

                    //敵の出現
                    int kind = Random.Range(0, enemys.Length - 1);

                    var ins = Instantiate(enemys[kind], spawns[index].transform.position, Quaternion.identity, spawns[index].transform);

                    spawns[index].isUsing = true;

                    spawnable = 0f;

                    break;
                }
            }
        }
    }
}