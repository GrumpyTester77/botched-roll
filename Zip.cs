using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ZipIt
{
     class Zip
    {
         //Zip Function
            //copy data to newly created file
         public static void zipFiles(string importPath)
         {

             //Getting the path and file
             Console.WriteLine("Please enter path of directory or file to zip: ");
             string zipPath = Console.ReadLine();
             directoryUtil.directoryCreateListOfFiles(zipPath, importPath);




                 Console.WriteLine("Files copied successfully");

                 Console.Read();
                 Console.ReadKey();
             }
         } 
}
