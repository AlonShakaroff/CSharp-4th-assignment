using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    internal class DelegateMainMenuExhibit
    {
        private readonly MainMenu r_MainMenu;

        public DelegateMainMenuExhibit()
        {
            r_MainMenu = new MainMenu();
        }

        public void CreateAndActivateMenu()
        {
            SubMenu dateTimeMenu = new SubMenu("Show Date/Time");
            ActionMenuItem showTimeMenuItem = new ActionMenuItem("Show Time", showDateMenuItem_ItemChosen);
            ActionMenuItem showDateMenuItem = new ActionMenuItem("Show Date", showTimeMenuItem_ItemChosen);
            SubMenu versionAndSpacesMenu = new SubMenu("Version and Spaces");
            ActionMenuItem countSpacesMenuItem = new ActionMenuItem("Count Spaces", countSpacesMenuItem_ItemChosen);
            ActionMenuItem showVersionMenuItem = new ActionMenuItem("Show Version", showVersionMenuItem_ItemChosen);

            dateTimeMenu.AddMenuItem(showTimeMenuItem);
            dateTimeMenu.AddMenuItem(showDateMenuItem);
            versionAndSpacesMenu.AddMenuItem(countSpacesMenuItem);
            versionAndSpacesMenu.AddMenuItem(showVersionMenuItem);
            r_MainMenu.AddMenuItem(dateTimeMenu);
            r_MainMenu.AddMenuItem(versionAndSpacesMenu);
            r_MainMenu.Show();
        }

        private void showTimeMenuItem_ItemChosen()
        {
            string currentTime = DateTime.Now.ToLongTimeString();

            Console.WriteLine(currentTime);
        }

        private void showDateMenuItem_ItemChosen()
        {
            string currentDate = DateTime.Today.ToShortDateString();

            Console.WriteLine(currentDate);
        }

        private void countSpacesMenuItem_ItemChosen()
        {
            string stringInputFromUser;
            int amountOfSpaces;

            Console.WriteLine("Please enter a string: ");
            stringInputFromUser = Console.ReadLine();
            amountOfSpaces = stringInputFromUser.Count(char.IsWhiteSpace);
            Console.WriteLine($"This string contains {amountOfSpaces} spaces.");
        }

        private void showVersionMenuItem_ItemChosen()
        {
            Console.WriteLine("Version: 22.2.4.8950");
        }
    }
}
