namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private readonly MenuHandler r_MenuHandler;

        public SubMenu(string i_ItemLabel)
            : base(i_ItemLabel)
        {
            r_MenuHandler = new MenuHandler(ItemLabel, false);
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            r_MenuHandler.AddMenuItem(i_MenuItem);
        }

        public override void ChooseItem()
        {
            r_MenuHandler.ShowMenu();
        }
    }
}