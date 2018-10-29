using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Park.Score
{
    static public class DifficlutySystem
    {
        public static float difficulty = 7.0f;
        public static string date, time, subject;

        static public string GetClassInfo()
        {
            return date + " " + time + " " + subject;
        }
    }
}