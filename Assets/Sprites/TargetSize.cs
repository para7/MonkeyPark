using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSize : MonoBehaviour
{
    public float nomalsize, dashsize;

    private Vector3 nomal, dash;

    private float ease;

    public float easetime = 1f;

    // Use this for initialization
    void Start()
    {
        nomal = new Vector3(nomalsize, nomalsize, nomalsize);

        dash = new Vector3(dashsize, dashsize, dashsize);
    }

    // Update is called once per frame
    void Update()
    {
        //イージングの手実装
        if (Input.GetKey(KeyCode.LeftShift))
        {
            ease += Time.deltaTime;
        }
        else
        {
            ease -= Time.deltaTime;
        }

        ease = Mathf.Clamp(ease, 0f, easetime);

        var adj = ease / easetime;

        var size = nomal * (1 - adj) + dash * adj;

        transform.localScale = size;
    }

}
