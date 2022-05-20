using System;

namespace Ex04.Menus.Delegates
{
    public class ActionMenuItem : MenuItem
    {
        public event Action ItemChosen;

        public ActionMenuItem(string i_ItemLabel, Action i_MenuItemsAction)
            : base(i_ItemLabel)
        {
            ItemChosen += i_MenuItemsAction;
        }

        public override void ChooseItem()
        {
            Console.Clear();
            OnItemChosen();
            Console.WriteLine("Press any key to go back to the previous menu...");
            Console.ReadLine();
        }

        protected virtual void OnItemChosen()
        {
            ItemChosen?.Invoke();
        }
    }
}