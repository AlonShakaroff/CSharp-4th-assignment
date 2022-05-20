namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private readonly string r_ItemLabel;

        protected MenuItem(string i_ItemLabel)
        {
            r_ItemLabel = i_ItemLabel;
        }

        public string ItemLabel
        {
            get
            {
                return r_ItemLabel;
            }
        }

        public abstract void ChooseItem();
    }
}