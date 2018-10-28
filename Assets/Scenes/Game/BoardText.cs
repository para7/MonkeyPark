using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Park.Score
{
    public class BoardText : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
            GetComponent<Text>().text = DifficlutySystem.GetClassInfo();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}