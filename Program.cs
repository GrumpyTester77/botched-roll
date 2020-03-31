using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;





namespace ZipIt
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            do
            {
                Menu.mainMenu();
            }
            while (userInput != 3);
        }
     }
}