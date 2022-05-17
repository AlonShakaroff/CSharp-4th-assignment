using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class TimeDisplayer : IInvokable
    {
        public void Invoke()
        {
            string currentTime = DateTime.Now.ToLongTimeString();

            Console.WriteLine(currentTime);
        }
    }
}
