using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int hiscore = 0;
    public static int score = 0;

    private string basemessage;
    private Text text;

    // Use this for initialization
    void Start()
    {
        if(hiscore < score)
        {
            hiscore = score;
        }
        score = 0;
        text = GetComponent<Text>();
        basemessage = text.text;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = basemessage + score.ToString();
    }
}
