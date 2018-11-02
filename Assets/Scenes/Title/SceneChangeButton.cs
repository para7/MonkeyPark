using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Para7.Utilities;
using UnityEngine.SceneManagement;
using Park.Score;

namespace Park.Title
{
    public class SceneChangeButton : MonoBehaviour
    {
        [SerializeField] string nextscenename = "";

        [SerializeField] AudioSource audiosource;

        public void OnClick()
        {
            audiosource.Play();

            SceneManager.LoadSceneAsync(nextscenename);
        }
    }
}