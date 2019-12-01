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

             //string addFile = "yes";
             string pathContent = null;
             string filePathInfo = null;
             string fileName = null;
             int fileNameLength = 0;
             long size = 0;
             byte[] content = null;



                Console.WriteLine("Please enter path of file to zip: ");
                pathContent = Console.ReadLine();
                filePathInfo = pathContent;
                FileInfo data = new FileInfo(filePathInfo);               
                fileName = Path.GetFileName(filePathInfo);
                fileNameLength = fileName.Length;
                size = data.Length;
                content = File.ReadAllBytes(pathContent);
                

                try
                {
                    BinaryWriter writer = new BinaryWriter(new FileStream(importPath, FileMode.Open));

                    writer.Write(fileNameLength);
                    writer.Write(fileName);
                    writer.Write(size);
                    writer.Write(pathContent);
                    writer.Write(content);
                    writer.Close();
                }
                finally
                {
                    BinaryWriter writer = new BinaryWriter(new FileStream(importPath, FileMode.Open));
                    writer.Close();
                }
                      
               
            
            Console.WriteLine("Files copied successfully");

            Console.Read();
            Console.ReadKey();

            
         }

         
    }
}
