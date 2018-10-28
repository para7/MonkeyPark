using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Park.Score;

namespace Park.Title
{
    public class DifficlutSetting : MonoBehaviour
    {
        public Setting date, time, subject;

        public void OnClick()
        {
            CalcDifficluty();

            SetClassText();
        }

        private void CalcDifficluty()
        {
            float dif = 1f;
            dif *= date.GetInfo().difficulty;
            dif *= time.GetInfo().difficulty;
            dif*= subject.GetInfo().difficulty;
        }

        private void SetClassText()
        {
            DifficlutySystem.date = date.GetInfo().str;
            DifficlutySystem.time = time.GetInfo().str;
            DifficlutySystem.subject = subject.GetInfo().str;
        }
    }
}
