using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public bool hiscore;

    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        int score = ScoreSystem.score;

        if(hiscore)
        {
            score = ScoreSystem.hiscore;
        }

        GetComponent<Text>().text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
