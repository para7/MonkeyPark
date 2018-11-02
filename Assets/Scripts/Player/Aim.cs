using UnityEngine;
using UnityEngine.UI;

public class Aim : MonoBehaviour
{
    // 照準のImageをインスペクターから設定
    [SerializeField]
    private RawImage aimPointImage;

    public Color head_color, target_color;
    private Color defaultcolor;

    public float range = 30f;

    private void Start()
    {
        defaultcolor = aimPointImage.color;
    }

    void Update()
    {
        // Rayを飛ばす（第1引数がRayの発射座標、第2引数がRayの向き）
        Ray ray = new Ray(transform.position, transform.forward);

        // outパラメータ用に、Rayのヒット情報を取得するための変数を用意
        RaycastHit hit;

        // シーンビューにRayを可視化するデバッグ（必要がなければ消してOK）
        Debug.DrawRay(ray.origin, ray.direction * range, Color.red, 0.0f);

        // Rayのhit情報を取得する
        if (Physics.Raycast(ray, out hit, range))
        {

            // Rayがhitしたオブジェクトのタグ名を取得
            string hitTag = hit.collider.tag;

            // タグの名前がEnemyだったら、照準の色が変わる
            if ((hitTag.Equals("EnemyHead")))
            {
                aimPointImage.color = head_color;
            }
            else if ((hitTag.Equals("Enemy")))
            {
                //照準を赤に変える
                aimPointImage.color = target_color;
            }
            else
            {
                aimPointImage.color = defaultcolor;
            }

        }
        else
        {
            aimPointImage.color = defaultcolor;
        }
    }
}