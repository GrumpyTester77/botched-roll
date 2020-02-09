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
         public static void zipFile(string importPath){

             byte[] fileName = null;
             int fileNameLength = 0;
                          
             //Getting the path and file
             Console.WriteLine("Please enter path of file to zip: ");
             string filePath = Console.ReadLine();
             string file = Path.GetFileName(filePath);

             //Convert the path from a string to bytes
             byte[] pathContent = Encoding.ASCII.GetBytes(filePath);
               
             //assigning the data ready to copy
             FileInfo data = new FileInfo(filePath);

             fileName = Encoding.ASCII.GetBytes(file);
             fileNameLength = fileName.Length;
             long size = data.Length;
             
             //copy the filename, length and size of data to the file
             BinaryWriter writer = null;


             try
             {


                 writer = new BinaryWriter(new FileStream(importPath, FileMode.Create));

                 writer.Write(fileNameLength);
                 writer.Write(fileName);
                 writer.Write(size);
                  writer.Close();
             }
             finally
             {
                 if (writer != null)
                     writer.Close();


             }
            
             //copy the contents of the file to the new file
             BinaryReader fileReader = new BinaryReader(new FileStream(filePath, FileMode.Open));
             BinaryWriter dataWriter = new BinaryWriter(new FileStream(importPath, FileMode.Append));

             fileUtils.appendToFile(fileReader, dataWriter, size);


             Console.WriteLine("Files copied successfully");

             Console.Read();
             Console.ReadKey();    
         }
         
    }
}
