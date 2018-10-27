using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UniRx;
using System;

public class EnemyMove : MonoBehaviour
{
    private LookCamera lookCamera;
    public float duration = 1f;
    public float lifetime = 5f;

    // Use this for initialization
    void Start()
    {
        lookCamera = this.GetComponent<LookCamera>();

        this.transform.DORotate(new Vector3(0, 0, 0), duration).OnComplete(() => lookCamera.enabled = true);

        Observable.Timer(TimeSpan.FromSeconds(duration + lifetime)).Subscribe(exit).AddTo(this);
    }

    private void exit(long _)
    {
        lookCamera.enabled = false;

        var angle = gameObject.transform.localEulerAngles;

        angle.x = 90;

        this.transform.DORotate(angle, duration).OnComplete(() => Destroy(this));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
