using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Park.Title
{
    public class ButtonBase : MonoBehaviour
    {
        public virtual void OnClick()  { Debug.Log("OnClick"); }
        public virtual void OnClick2() { Debug.Log("OnClick2"); }
    }

    public class ButtonNofitication : MonoBehaviour
    {
        [SerializeField] ButtonBase otherbutton = null;

        public void OnClick()
        {
            otherbutton.OnClick();
        }

        public void OnClick2()
        {
            otherbutton.OnClick2();
        }
    }
}