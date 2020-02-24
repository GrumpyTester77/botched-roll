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
         public static void zipFiles(string importPath){

             //Getting the path and file
             Console.WriteLine("Please enter path of file to zip: ");
             string filePath = Console.ReadLine();
             string file = Path.GetFileName(filePath);
                                                 
             //copy the contents of the file to the new file
             BinaryReader fileReader = new BinaryReader(new FileStream(filePath, FileMode.Open));
             BinaryWriter dataWriter = new BinaryWriter(new FileStream(importPath, FileMode.Append));

             zipFile.importFile(filePath, file, dataWriter, fileReader);

             Console.WriteLine("Files copied successfully");

             Console.Read();
             Console.ReadKey();    
         }
         
    }
}
