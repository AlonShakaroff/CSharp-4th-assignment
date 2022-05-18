using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class ActionMenuItem : MenuItem
    {
        private readonly IInvokable r_ItemsAction;

        public ActionMenuItem(string i_ItemLabel, IInvokable i_ItemsAction)
            : base(i_ItemLabel)
        {
            r_ItemsAction = i_ItemsAction;
        }

        public override void ChooseItem()
        {
            Console.Clear();
            r_ItemsAction.Invoke();
            Console.WriteLine("Press any key to go back to the previous menu...");
            Console.ReadLine();
        }
    }
}

