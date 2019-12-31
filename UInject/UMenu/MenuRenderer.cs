using System.Collections.Generic;
using UnityEngine;
using UInject.Utilities;
using System;
using System.Reflection;

namespace UInject.UMenu
{
    public class MenuRenderer
    {
        private MenuSkinSetup skinSetup;
        private GUISkin guiSkin;

        public List<MenuItem> menuItems { get; protected set; }

        private float optionBufferSize = 35f;

        private Rect windowPosition;
        protected static bool isOpen;

        protected string _menuName;
        protected int _menuId;

        private Texture2D mouseTexture;

        public MenuRenderer()
        {
            skinSetup = new MenuSkinSetup();
            mouseTexture = skinSetup.GetTextureFromResource(Assembly.GetExecutingAssembly(), "UInject.Resources.UInjectMouse.png");

            isOpen = false;

            // Pretty ghetto, get over it :)
            int menuCount = MenuManager.menuManagers.Count;
            float xPos = 50f + (menuCount % 3) * 510f;
            float yPos = 25f + (float)Math.Floor(menuCount / 3f) * 400f;
            windowPosition = new Rect(xPos, yPos, 500f, 30f);

            guiSkin = skinSetup.SetupMenuSkin();
        }

        private void windowCallback(int windowId)
        {
            int itemId = 0;
            foreach (var menuItem in menuItems)
            {
                menuItem.Handle(itemId, new Rect(10f, optionBufferSize * (itemId - 1), 500f, 30f), guiSkin);

                itemId++;
            }

            GUI.DragWindow();
        }

        public void Render()
        {
            if (!isOpen)
                return;

            GUI.skin = guiSkin;

            windowPosition.height = 370f;

            GUI.depth = 1;
            windowPosition = GUI.Window(_menuId, windowPosition, windowCallback, _menuName, guiSkin.window);

            GUI.depth = 0;
            GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 32, 32), mouseTexture);
        }
    }
}
