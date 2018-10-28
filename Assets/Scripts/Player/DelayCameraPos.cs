using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Park.Player
{
    public class DelayCameraPos : MonoBehaviour
    {
        [SerializeField] int delaySize = 20;

        private Vector3[] cameraPosList;

        int getIndex = 0;
        static Vector3 ret = Vector3.zero;

        // Use this for initialization
        void Start()
        {
            cameraPosList = Enumerable.Repeat(Camera.main.transform.position, delaySize).ToArray();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            getIndex = (getIndex + 1) % delaySize;
            ret = cameraPosList[getIndex];
            cameraPosList[getIndex] = Camera.main.transform.position;
        }

        static public Vector3 GetDelayCameraPos()
        {
            return ret;
        }
    }
}