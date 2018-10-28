using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Park.Enemy
{
    public class LookCamera : MonoBehaviour
    {
        public bool enableJumpRotate = true;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //https://www.f-sp.com/entry/2017/08/30/171353

            // メインカメラの取得
            if (Camera.main) // カメラ有効時のみ
            {
                // カメラに向かう方向を計算
                Vector3 forward = Park.Player.DelayCameraPos.GetDelayCameraPos() - transform.position;

                if (!enableJumpRotate)
                {
                    forward = new Vector3(-forward.x, 0, -forward.z);
                }

                if (forward != Vector3.zero) // 零ベクトルでない
                {
                    // カメラの向きを正面とする回転を作成して適用
                    transform.rotation = Quaternion.LookRotation(forward);
                }
            }
        }
    }
}
