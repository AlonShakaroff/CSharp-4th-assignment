using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class TimeDisplayer : IInvokable
    {
        public void Invoke()
        {
            string currentTime = DateTime.Now.ToLongTimeString();

            Console.WriteLine("The current time is: {0}", currentTime);
        }
    }
}