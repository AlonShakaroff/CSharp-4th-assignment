using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    internal class MainMenu
    {
        private readonly List<MenuItem> r_MenuItems;

        public List<MenuItem> MenuItems
        {
            get
            {
                return r_MenuItems;
            }
        }

        public MainMenu()
        {
            r_MenuItems = new List<MenuItem>();
        }
    }
}
