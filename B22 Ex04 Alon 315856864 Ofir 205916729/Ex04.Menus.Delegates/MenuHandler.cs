using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    internal class MenuHandler
    {
        private readonly List<MenuItem> r_MenuItemsList;
        private readonly string r_Title;
        private readonly bool r_IsMainMenuFlag;

        public MenuHandler(string i_Title, bool i_IsMainMenu)
        {
            r_MenuItemsList = new List<MenuItem>();
            r_Title = i_Title;
            r_IsMainMenuFlag = i_IsMainMenu;
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            r_MenuItemsList.Add(i_MenuItem);
        }

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.Clear();
                printMenu();
                choice = getChoiceFromUser();
                if (choice != 0)
                {
                    r_MenuItemsList[choice - 1].ChooseItem();
                }
            }
            while (choice != 0);
        }

        private void printMenu()
        {
            int itemIndex = 1;
            StringBuilder printedMenu = new StringBuilder();

            printedMenu.AppendFormat("{0}{1}{1}", r_Title, Environment.NewLine);
            foreach (MenuItem menuItem in r_MenuItemsList)
            {
                printedMenu.AppendFormat("{0}. {1}{2}", itemIndex, menuItem.ItemLabel, Environment.NewLine);
                itemIndex++;
            }

            if (r_IsMainMenuFlag)
            {
                printedMenu.AppendLine("0. Exit");
            }
            else
            {
                printedMenu.AppendLine("0. Back");
            }

            Console.Write(printedMenu.ToString());
        }

        private int getChoiceFromUser()
        {
            int choice;

            while (int.TryParse(Console.ReadLine(), out choice) == false)
            {
                Console.WriteLine($"Please choose a number between 0 and {r_MenuItemsList.Count}: ");
            }

            return choice;
        }
    }
}
