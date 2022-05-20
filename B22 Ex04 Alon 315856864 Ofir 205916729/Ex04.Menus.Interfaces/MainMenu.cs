namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private const string k_MainMenuTitle = "Interface Main Menu";
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