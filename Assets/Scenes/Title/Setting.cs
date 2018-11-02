using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Park.Title
{
    public class Setting : ButtonBase
    {
        [System.Serializable]
        public class SlotElement
        {
            public string str = "";
            public float difficulty = 0.0f;
        }

        public SlotElement[] elements;

        private int cursor = 0;

        [SerializeField] AudioSource se;

        public override void OnClick()
        {
            se.Play();

            cursor += elements.Length - 1;

            cursor = cursor % elements.Length;

            OnChangeIndex();
        }

        public override void OnClick2()
        {
            se.Play();
            cursor++;

            cursor = cursor % elements.Length;

            OnChangeIndex();
        }

        private Text text;

        public void Start()
        {
            text = GetComponent<Text>();

            text.text = elements[cursor].str;
        }

        void OnChangeIndex()
        {
            text.text = elements[cursor].str;
        }

        public SlotElement GetInfo()
        {
            return elements[cursor];
        }
    }
}