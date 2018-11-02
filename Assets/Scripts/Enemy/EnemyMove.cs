using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UniRx;
using System;

namespace Park.Enemy
{
    public class EnemyMove : MonoBehaviour
    {
        private LookCamera lookCamera;
        public float duration = 1f;
        public float lifetime = 5f;

        IDisposable disposable;

        // Use this for initialization
        void Start()
        {
            // カメラに向かう方向を計算
            Vector3 forward = transform.position - Park.Player.DelayCameraPos.GetDelayCameraPos();

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

            disposable = Observable.Timer(TimeSpan.FromSeconds(duration + lifetime)).Subscribe(exit).AddTo(this);
        }

        public AudioSource hidese;
        public AudioSource deadse;

        private void exit(long _)
        {
            hidese.Play();

            lookCamera.enabled = false;

            var angle = gameObject.transform.localEulerAngles;

            angle.x = 90;

            this.transform.DORotate(angle, duration).OnComplete(() => Destroy(this.gameObject));
            
            ScoreSystem.score -= 300;
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnDead()
        {
            deadse.Play();

            disposable.Dispose();

            Observable.Timer(TimeSpan.FromSeconds(1f)).Subscribe(_ => Destroy(this.gameObject)).AddTo(this);

            var colliders = GetComponentsInChildren<BoxCollider>();

            foreach (var c in colliders)
            {
                c.enabled = false;
            }
        }
    }
}