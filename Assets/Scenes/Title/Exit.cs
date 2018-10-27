using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace My.Title
{
    public class Exit : MonoBehaviour
    {
        public void Update()
        {
            var i = Input.GetAxis("Horizontal");
            if(i > 0.1)
            {
                OnClick();
            }
        }

        public void OnClick()
        {
            Debug.Log("exit");
            Application.Quit();
        }
    }
}