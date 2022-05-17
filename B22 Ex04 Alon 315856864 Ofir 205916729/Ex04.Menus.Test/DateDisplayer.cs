using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class DateDisplayer : IInvokable
    {
        public void Invoke()
        {
            string currentDate = DateTime.Today.ToShortDateString();

            Console.WriteLine(currentDate);
        }
    }
}
