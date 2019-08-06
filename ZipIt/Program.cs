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
           
            string importPath = "null";
            string inputKey = "";

            Console.WriteLine("Please select from the following options", "\n");
            Console.WriteLine("Option 1, Zip file(s)","\n");
            Console.WriteLine("Option 2, Unzip file(s)","\n");
            inputKey = Console.ReadLine();
            int result = Int32.Parse(inputKey);

            if (result == 1)
            {
                importPath = Files.createFiles();
                Zip.zipFile(importPath);

            }

            else if (result == 2)
            {
                Unzip.unzipFiles();
            }

            else 
            {
                Console.WriteLine("invalid option");
                Console.Read();
               
            }     
            
        }

    }
}
