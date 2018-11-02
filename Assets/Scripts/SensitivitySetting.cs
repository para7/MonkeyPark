using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SensitivitySetting : MonoBehaviour
{
    public static float sensitivity = 5f; 

    // Use this for initialization
    void Start()
    {
        GetComponent<MouseLook>().XSensitivity = sensitivity;
        GetComponent<MouseLook>().YSensitivity = sensitivity;
    }
}
