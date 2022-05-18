using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class VersionDisplayer : IInvokable
    {
        public void Invoke()
        {
            Console.WriteLine("Version: 22.2.4.8950");
        }
    }
}
