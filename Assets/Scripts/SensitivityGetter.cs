using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensitivityGetter : MonoBehaviour
{
    public Slider slider;

    // Update is called once per frame
    void Update()
    {
        SensitivitySetting.sensitivity = slider.value;
    }
}
