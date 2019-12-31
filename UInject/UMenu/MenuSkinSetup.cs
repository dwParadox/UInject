using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UInject.UMenu
{
    public class MenuSkinSetup
    {
        private GUISkin _guiSkin;
        public MenuSkinSetup()
        {
            _guiSkin = (GUISkin)ScriptableObject.CreateInstance(typeof(GUISkin));
        }

        public Texture2D GetTextureFromResource(Assembly assembly, string texturePath)
        {
            using (var stream = assembly.GetManifestResourceStream(texturePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                
                Texture2D outTex = new Texture2D(1, 1);
                outTex.LoadImage(buffer);

                return outTex;
            }
        }

        private Texture2D windowTex;
        private void WindowSetup(Assembly assembly, Font font)
        {
            windowTex = GetTextureFromResource(assembly, "UInject.Resources.UInjectBackground.png");
            _guiSkin.window.normal.background = windowTex;
            _guiSkin.window.onNormal.background = windowTex;

            _guiSkin.window.alignment = TextAnchor.UpperCenter;
            _guiSkin.window.font = font;
            _guiSkin.window.normal.textColor = Color.white;
            _guiSkin.window.onNormal.textColor = Color.white;
            _guiSkin.window.contentOffset = new Vector2(0f, 15f);
        }

        private Texture2D toggleTexOn, toggleTexOff;
        private void ToggleSetup(Assembly assembly, Font font)
        {
            toggleTexOn = GetTextureFromResource(assembly, "UInject.Resources.UInjectToggleOn.png");
            toggleTexOff = GetTextureFromResource(assembly, "UInject.Resources.UInjectToggleOff.png");

            _guiSkin.toggle.font = font;
            _guiSkin.toggle.normal.textColor = Color.white;
            _guiSkin.toggle.onNormal.textColor = Color.white;
            _guiSkin.toggle.normal.background = toggleTexOff;
            _guiSkin.toggle.onNormal.background = toggleTexOn;

            _guiSkin.toggle.border = new RectOffset(14, 0, 14, 0);
            _guiSkin.toggle.margin = new RectOffset(4, 4, 4, 4);
            _guiSkin.toggle.padding = new RectOffset(-30, 0, 3, 0);
            _guiSkin.toggle.overflow = new RectOffset(0, 0, -2, 0);
            _guiSkin.toggle.alignment = TextAnchor.UpperLeft;
            _guiSkin.toggle.imagePosition = ImagePosition.ImageLeft;
            _guiSkin.toggle.contentOffset = new Vector2(55f, 0f);
        }

        private void LabelSetup(Font font)
        {
            _guiSkin.label.font = font;
            _guiSkin.label.normal.textColor = Color.white;
        }

        private Texture2D sliderTex, sliderThumbTex;
        private void SliderSetup(Assembly assembly, Font font)
        {
            sliderTex = GetTextureFromResource(assembly, "UInject.Resources.UInjectSlider.png");
            sliderThumbTex = GetTextureFromResource(assembly, "UInject.Resources.UInjectSliderThumb.png");

            _guiSkin.horizontalSlider.normal.background = sliderTex;
            _guiSkin.horizontalSliderThumb.normal.background = sliderThumbTex;

            _guiSkin.horizontalSlider.border = new RectOffset(3, 3, 0, 0);
            _guiSkin.horizontalSlider.margin = new RectOffset(4, 4, 4, 4);
            _guiSkin.horizontalSlider.padding = new RectOffset(-1, -1, 0, 0);
            _guiSkin.horizontalSlider.overflow = new RectOffset(0, 0, -2, -3);
            _guiSkin.horizontalSlider.alignment = TextAnchor.UpperLeft;
            _guiSkin.horizontalSlider.imagePosition = ImagePosition.ImageOnly;
            _guiSkin.horizontalSlider.contentOffset = new Vector2(0f, 0f);
            _guiSkin.horizontalSlider.fixedHeight = 12f;
            _guiSkin.horizontalSlider.fixedWidth = 0f;

            _guiSkin.horizontalSlider.stretchWidth = false;
            _guiSkin.horizontalSlider.stretchHeight = true;

            _guiSkin.horizontalSliderThumb.border = new RectOffset(4, 4, 0, 0);
            _guiSkin.horizontalSliderThumb.margin = new RectOffset(0, 0, 0, 0);
            _guiSkin.horizontalSliderThumb.padding = new RectOffset(7, 7, 0, 0);
            _guiSkin.horizontalSliderThumb.overflow = new RectOffset(-1, -1, 0, 0);
            _guiSkin.horizontalSliderThumb.alignment = TextAnchor.UpperLeft;
            _guiSkin.horizontalSliderThumb.imagePosition = ImagePosition.ImageOnly;
            _guiSkin.horizontalSliderThumb.contentOffset = new Vector2(0f, 0f);
            _guiSkin.horizontalSliderThumb.fixedHeight = 12f;
            _guiSkin.horizontalSliderThumb.fixedWidth = 0f;

            _guiSkin.horizontalSliderThumb.stretchWidth = false;
            _guiSkin.horizontalSliderThumb.stretchHeight = true;
        }

        private Texture2D buttonTexOff, buttonTexOn;
        private void ButtonSetup(Assembly assembly, Font font)
        {
            buttonTexOff = GetTextureFromResource(assembly, "UInject.Resources.UInjectButton.png");
            buttonTexOn = GetTextureFromResource(assembly, "UInject.Resources.UInjectButtonSelected.png");

            _guiSkin.button.font = font;
            _guiSkin.button.normal.background = buttonTexOff;
            _guiSkin.button.hover.background = buttonTexOn;
            _guiSkin.button.active.background = buttonTexOff;
            _guiSkin.button.normal.textColor = Color.white;
            _guiSkin.button.hover.textColor = Color.white;
            _guiSkin.button.active.textColor = Color.white;

            _guiSkin.button.border = new RectOffset(6, 6, 6, 4);
            _guiSkin.button.margin = new RectOffset(4, 4, 4, 4);
            _guiSkin.button.padding = new RectOffset(6, 6, 3, 3);
            _guiSkin.button.overflow = new RectOffset(0, 0, 0, 0);
            _guiSkin.button.alignment = TextAnchor.MiddleCenter;
            _guiSkin.button.imagePosition = ImagePosition.ImageLeft;
            _guiSkin.button.contentOffset = new Vector2(0f, -2f);
            _guiSkin.button.fixedHeight = 0f;
            _guiSkin.button.fixedWidth = 0f;
        }

        private void ScrollbarSetup(Assembly assembly)
        {
            _guiSkin.verticalScrollbar.normal.background = sliderTex;
            _guiSkin.verticalScrollbarThumb.normal.background = sliderThumbTex;

            _guiSkin.verticalScrollbar.border = new RectOffset(0, 0, 9, 9);
            _guiSkin.verticalScrollbar.margin = new RectOffset(1, 4, 4, 4);
            _guiSkin.verticalScrollbar.padding = new RectOffset(0, 0, 1, 1);
            _guiSkin.verticalScrollbar.overflow = new RectOffset(0, 0, 0, 0);
            _guiSkin.verticalScrollbar.alignment = TextAnchor.UpperLeft;
            _guiSkin.verticalScrollbar.imagePosition = ImagePosition.ImageLeft;
            _guiSkin.verticalScrollbar.contentOffset = new Vector2(0f, 0f);
            _guiSkin.verticalScrollbar.fixedWidth = 15f;
            _guiSkin.verticalScrollbar.fixedHeight = 0f;

            _guiSkin.verticalScrollbar.stretchWidth = true;
            _guiSkin.verticalScrollbar.stretchHeight = false;

            _guiSkin.verticalScrollbarThumb.border = new RectOffset(6, 6, 6, 6);
            _guiSkin.verticalScrollbarThumb.margin = new RectOffset(0, 0, 0, 0);
            _guiSkin.verticalScrollbarThumb.padding = new RectOffset(0, 0, 6, 6);
            _guiSkin.verticalScrollbarThumb.overflow = new RectOffset(-1, -1, 0, 0);
            _guiSkin.verticalScrollbarThumb.alignment = TextAnchor.UpperLeft;
            _guiSkin.verticalScrollbarThumb.imagePosition = ImagePosition.ImageOnly;
            _guiSkin.verticalScrollbarThumb.contentOffset = new Vector2(0f, 0f);
            _guiSkin.verticalScrollbarThumb.fixedWidth = 15f;
            _guiSkin.verticalScrollbarThumb.fixedHeight = 0f;

            _guiSkin.verticalScrollbarThumb.stretchWidth = true;
            _guiSkin.verticalScrollbarThumb.stretchHeight = false;
        }

        private void TextFieldSetup(Assembly assembly, Font font)
        {
            _guiSkin.textField.font = font;
            _guiSkin.textField.normal.background = buttonTexOff;
            _guiSkin.textField.active.background = buttonTexOff;
            _guiSkin.textField.onNormal.background = buttonTexOff;
            _guiSkin.textField.hover.background = buttonTexOff;

            _guiSkin.textField.normal.textColor = Color.white;
            _guiSkin.textField.active.textColor = Color.white;
            _guiSkin.textField.onNormal.textColor = Color.white;
            _guiSkin.textField.hover.textColor = Color.white;

            _guiSkin.textField.border = new RectOffset(4, 4, 4, 4);
            _guiSkin.textField.margin = new RectOffset(4, 4, 4, 4);
            _guiSkin.textField.padding = new RectOffset(3, 3, 3, 3);
            _guiSkin.textField.overflow = new RectOffset(0, 0, 0, 0);
            _guiSkin.textField.alignment = TextAnchor.UpperLeft;
            _guiSkin.textField.imagePosition = ImagePosition.TextOnly;
            _guiSkin.textField.contentOffset = new Vector2(0f, 0f);
            _guiSkin.textField.fixedHeight = 0f;
            _guiSkin.textField.fixedWidth = 0f;
        }

        public GUISkin SetupMenuSkin()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Font menuFont = Font.CreateDynamicFontFromOSFont("Calibri", 14);

            _guiSkin.font = menuFont;
            _guiSkin.settings.selectionColor = new Color(0, 0.5f, 1f);

            WindowSetup(assembly, menuFont);
            LabelSetup(menuFont);
            ToggleSetup(assembly, menuFont);
            SliderSetup(assembly, menuFont);
            ButtonSetup(assembly, menuFont);
            ScrollbarSetup(assembly);
            TextFieldSetup(assembly, menuFont);

            return _guiSkin;
        }
    }
}
