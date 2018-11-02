using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Park.Score
{
    static public class DifficlutySystem
    {
        public static float difficulty = 10.0f * 0.2f;
        public static string date, time, subject;

        static public string GetClassInfo()
        {
            return date + " " + time + " " + subject;
        }
    }
}