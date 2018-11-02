using System.Collections;
using System.Collections.Generic;
using Park.Enemy;
using UnityEngine;
using UnityEngine.UI;

public class MonkeyCount : MonoBehaviour
{
    private string basemessage;
    private Text text;
    [SerializeField] EnemyServer server;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        basemessage = text.text;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = basemessage + server.EnemyNum.ToString();
    }
}
