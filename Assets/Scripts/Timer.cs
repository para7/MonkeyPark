using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //[SerializeField] int countdown = 3;

    [SerializeField] float time = 30f;
    public float Time => time;

    //[SerializeField] GameObject[] StartEnableUI;

    //private float counttimer = 0f;

    // Use this for initialization
    void Start()
    {
        //カウント効果音
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //開始前
        if(countdown > 0)
        {
            counttimer += UnityEngine.Time.deltaTime;
            if(counttimer > 1f)
            {
                counttimer -= 1f;

                countdown--;

                //カウント効果音

                if(countdown == 0)
                {
                    foreach(var s in StartEnableUI)
                    {
                        s?.SetActive(true);
                    }
                }
            }
            return;
        }
        */
        time -= UnityEngine.Time.deltaTime;
    }
}
