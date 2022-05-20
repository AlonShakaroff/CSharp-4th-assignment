using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class InterfaceMainMenuExhibit
    {
        private readonly MainMenu r_MainMenu;

        public InterfaceMainMenuExhibit()
        {
            r_MainMenu = new MainMenu();
        }

        public void CreateAndActivateMenu()
        {
            SubMenu dateTimeMenu = new SubMenu("Show Date/Time");
            ActionMenuItem showTimeMenuItem = new ActionMenuItem("Show Time", new TimeDisplayer());
            ActionMenuItem showDateMenuItem = new ActionMenuItem("Show Date", new DateDisplayer());
            SubMenu versionAndSpacesMenu = new SubMenu("Version and Spaces");
            ActionMenuItem countSpacesMenuItem = new ActionMenuItem("Count Spaces", new StringInputSpacesCounter());
            ActionMenuItem showVersionMenuItem = new ActionMenuItem("Show Version", new VersionDisplayer());

            dateTimeMenu.AddMenuItem(showTimeMenuItem);
            dateTimeMenu.AddMenuItem(showDateMenuItem);
            versionAndSpacesMenu.AddMenuItem(countSpacesMenuItem);
            versionAndSpacesMenu.AddMenuItem(showVersionMenuItem);
            r_MainMenu.AddMenuItem(dateTimeMenu);
            r_MainMenu.AddMenuItem(versionAndSpacesMenu);
            r_MainMenu.Show();
        }
    }
}