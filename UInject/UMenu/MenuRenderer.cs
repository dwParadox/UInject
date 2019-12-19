using System.Collections.Generic;
using UnityEngine;

namespace UInject.UMenu
{
    public class MenuRenderer
    {
        public List<MenuItem> menuItems { get; protected set; }

        private float optionBufferSize = 35f;

        private Rect windowPosition;
        protected static bool isOpen;

        protected string _menuName;
        protected int _menuId;

        public MenuRenderer()
        {
            isOpen = false;
            windowPosition = new Rect(50f + (MenuManager.menuManagers.Count) * 510f, 25f, 500f, 30f);
        }

        private void windowCallback(int windowId)
        {
            int itemId = 0;
            foreach (var menuItem in menuItems)
            {
                menuItem.Handle(itemId, new Rect(10f, 40f + optionBufferSize * itemId, 500f, 30f));

                itemId++;
            }

            GUI.DragWindow();
        }

        public void Render()
        {
            if (!isOpen)
                return;

            GUI.color = Color.white;
            GUI.backgroundColor = Color.black;

            windowPosition.height = 50f + (menuItems.Count * optionBufferSize);

            windowPosition = GUI.Window(_menuId, windowPosition, windowCallback, _menuName);
        }
    }
}
