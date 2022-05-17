using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class StringInputSpacesCounter : IInvokable
    {
        public void Invoke()
        {
            string stringInputFromUser;
            int amountOfSpaces;

            Console.WriteLine("Please enter a string: ");
            stringInputFromUser = Console.ReadLine();
            amountOfSpaces = stringInputFromUser.Count(char.IsWhiteSpace);
            Console.WriteLine($"This string contains {amountOfSpaces} spaces.");
        }
    }
}
