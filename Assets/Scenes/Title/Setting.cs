using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace My.GUI
{
    public class Setting : ButtonBase
    {
        [System.Serializable]
        public class SlotElement
        {
            public string str = "";
            public double difficulty = 0.0;
        }

        public SlotElement[] elements;

        private int cursor = 0;

        public override void OnClick()
        {
            cursor += elements.Length - 1;

            cursor = cursor % elements.Length;

            OnChangeIndex();
        }

        public override void OnClick2()
        {
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
    }
}