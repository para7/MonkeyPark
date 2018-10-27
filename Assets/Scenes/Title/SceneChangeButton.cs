using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Para7.Utilities;
using UnityEngine.SceneManagement;

public class SceneChangeButton : MonoBehaviour
{
    [SerializeField] string nextscenename = "";

    public void OnClick()
    {
        SceneManager.LoadSceneAsync(nextscenename);
    }
}
