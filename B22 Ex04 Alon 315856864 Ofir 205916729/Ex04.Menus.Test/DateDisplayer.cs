using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class DateDisplayer : IInvokable
    {
        public void Invoke()
        {
            string todaysDate = DateTime.Today.ToShortDateString();

            Console.WriteLine("Today's date is: {0}", todaysDate);
        }
    }
}