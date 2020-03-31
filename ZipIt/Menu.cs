using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZipIt
{
    class Menu
    {
        public static void mainMenu()
        {

                Console.WriteLine("Main Menu");
                Console.WriteLine("Option 1, Zip file(s)");
                Console.WriteLine("Option 2, Unzip file(s)");
                Console.WriteLine("Option 3, Exit");
                Console.WriteLine("Please select an options from the list.");
                string inputKey = Console.ReadLine();
                int result = Int32.Parse(inputKey);

                if (result == 1)
                {

                    Console.Clear();
                    string importPath = "null";
                    importPath = Files.createFiles();
                    Zip.zipFiles(importPath);
                    Console.Clear();

                }

                else if (result == 2)
                {
                    Console.Clear();
                    Unzip.unzipFiles();
                    Console.Clear();
                    
                }

                else if (result == 3)
                {
                    Environment.Exit(0);
                    
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("invalid option");
                    Console.Clear();
                    
                }
            }
        }
    }
