using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSize : MonoBehaviour
{
    public float nomalsize, dashsize;

    private Vector3 nomal, dash;

    // Use this for initialization
    void Start()
    {
        nomal = new Vector3(nomalsize, nomalsize, nomalsize);

        dash = new Vector3(dashsize, dashsize, dashsize);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.localScale = dash;
        }
        else
        {
            transform.localScale = nomal;
        }
    }

}
