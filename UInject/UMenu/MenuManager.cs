﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UInject.UMenu
{
    public class MenuManager : MenuRenderer
    {
        public delegate List<MenuItem> SetupAction();
        public static List<MenuManager> menuManagers = new List<MenuManager>();

        public MenuManager(SetupAction setupAction, string menuName)
        {
            this.menuItems = setupAction();
            this._menuName = menuName;
            this._menuId = 150 + menuManagers.Count;
            menuManagers.Add(this);
        }

        public static MenuManager GetMenu(string menuName)
        {
            foreach (var m in menuManagers)
            {
                if (menuName.Equals(m._menuName))
                    return m;
            }

            return null;
        }
        
        /*
        public dynamic this[string index] 
        {
            get { return menuItems.Where(i => index.Equals(i.Title)).FirstOrDefault().Value; }
            set { menuItems.Where(i => index.Equals(i.Title)).FirstOrDefault().Value = value; }
        }
        */

        public float GetValue(string index)
        {
            foreach (var i in menuItems)
            {
                if (index.Equals(i.Title))
                    return i.Value;
            }

            return 0.0f;
        }
        public void SetValue(string index, float value)
        {
            foreach (var i in menuItems)
            {
                if (index.Equals(i.Title))
                    i.Value = value;
            }
        }

        public string GetInput(string index)
        {
            foreach (var i in menuItems)
            {
                if (index.Equals(i.Title))
                    return i.Input;
            }

            return "";
        }
        public void SetInput(string index, string value)
        {
            foreach (var i in menuItems)
            {
                if (index.Equals(i.Title))
                    i.Input = value;
            }
        }

        public bool GetEnabled(string index)
        {
            foreach (var i in menuItems)
            {
                if (index.Equals(i.Title))
                    return i.Enabled;
            }

            return false;
        }
        public void SetEnabled(string index, bool value)
        {
            foreach (var i in menuItems)
            {
                if (index.Equals(i.Title))
                    i.Enabled = value;
            }
        }

        private static bool _stateSet = false;
        private static CursorLockMode _lastState;

        public static void OpenClose()
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
                isOpen = !isOpen;

            if (isOpen && _stateSet)
            {
                Cursor.lockState = CursorLockMode.None;
            }

            if (isOpen && !_stateSet)
            {
                _stateSet = true;
                _lastState = Cursor.lockState;
                Cursor.lockState = CursorLockMode.None;
            }
            else if (!isOpen && _stateSet)
            {
                _stateSet = false;
                Cursor.lockState = _lastState;
            }
        }
    }
}
