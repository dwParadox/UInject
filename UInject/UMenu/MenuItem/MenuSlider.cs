using System;
using UnityEngine;

namespace UInject.UMenu
{
    public class MenuSlider : MenuItem
    {
        private readonly float minValue, maxValue;

        public MenuSlider(string title, float min, float max, float cur)
        {
            this.Title = title;
            this.minValue = min;
            this.maxValue = max;
            this.Value = cur;
        }

        public override void Handle(int itemId, Rect pos, GUISkin skin)
        {
            GUI.color = Color.white;
            GUI.Label(pos, Title + " (" + Math.Floor(this.Value) + ")", skin.label);
            this.Value = GUI.HorizontalSlider(new Rect(250f, pos.y + 5f, 210f, 20f), this.Value, this.minValue, this.maxValue, skin.horizontalSlider, skin.horizontalSliderThumb);
        }
    }
}
