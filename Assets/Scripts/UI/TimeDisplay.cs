using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Park.UI
{
    public class TimeDisplay : MonoBehaviour
    {
        private string basemessage;
        private Text text;
        public Timer timer;
       
        // Use this for initialization
        void Start()
        {
            text = GetComponent<Text>();
            basemessage = text.text;
        }

        // Update is called once per frame
        void Update()
        {
            text.text = basemessage + ((int)(timer.Time)).ToString();
        }
    }
}