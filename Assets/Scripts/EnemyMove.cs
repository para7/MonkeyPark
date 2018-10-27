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
        // カメラに向かう方向を計算
        Vector3 forward = transform.position - DelayCameraPos.GetDelayCameraPos();

        if (forward != Vector3.zero) // 零ベクトルでない
        {
            // カメラの向きを正面とする回転を作成して適用
            transform.rotation = Quaternion.LookRotation(forward);
        }

        var e = transform.eulerAngles;

        e.x = 90;

        transform.eulerAngles = e;

        lookCamera = this.GetComponent<LookCamera>();

        e.x = 0;

        this.transform.DORotate(e, duration).OnComplete(() => lookCamera.enabled = true);

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
