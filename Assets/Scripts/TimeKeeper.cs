using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeKeeper : MonoBehaviour
{
    [SerializeField] Timer timer;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(timer.Time < 0)
        {
            SceneManager.LoadSceneAsync("Result");
        }
    }
}
