using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SensitivitySetting : MonoBehaviour
{
    public static float sensitivity = 5f;

    public FirstPersonController controller;

    // Use this for initialization
    void Start()
    {
        controller.m_MouseLook.XSensitivity = sensitivity;
        controller.m_MouseLook.YSensitivity = sensitivity;
    }
}
