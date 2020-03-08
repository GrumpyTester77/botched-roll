using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ZipIt
{
    class Files
    {

        //Selecting files
        //Create a new file
        public static string createFiles(){
        string importPath;
        Console.WriteLine("To create the file, Please enter the path and filename: ");
        importPath = Console.ReadLine();

       
            if (File.Exists(importPath))
            {
                Console.WriteLine("File already Exists: " + importPath);
            }
            else
            {
                FileStream newFile = File.Create(importPath);
                Console.WriteLine("File Created: " + importPath);
                newFile.Close();
             
            }

            return importPath;

        }
    }
}
