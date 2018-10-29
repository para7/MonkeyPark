using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class TimeDelete : MonoBehaviour
{
    public float timer = 5f;
    bool delete = false;

    // Use this for initialization
    void Start()
    {
        if (delete)
        {
            Observable.Timer(TimeSpan.FromSeconds(timer)).Subscribe(DeleteThis).AddTo(this);
        }
        else
        {
            Observable.Timer(TimeSpan.FromSeconds(timer)).Subscribe(StopThis).AddTo(this);
        }
    }

    void StopThis(long _)
    {
        this.gameObject.SetActive(false);
    }

    void DeleteThis(long _)
    {
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
