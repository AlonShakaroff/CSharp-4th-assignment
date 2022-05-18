using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private const string k_MainMenuTitle = "Delegates main menu";
        private readonly MenuHandler r_MenuHandler;

        public MainMenu()
        {
            r_MenuHandler = new MenuHandler(k_MainMenuTitle, true);
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            r_MenuHandler.AddMenuItem(i_MenuItem);
        }

        public void Show()
        {
            r_MenuHandler.ShowMenu();
        }
    }
}
