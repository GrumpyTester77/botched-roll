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
             int size = 0;
             byte[] content = null;
                          
             Console.WriteLine("Please enter path of file to zip: ");
             string pathContentString = Console.ReadLine();
             byte[] pathContent = Encoding.ASCII.GetBytes(pathContentString);
             string filePathInfo = pathContentString;
             FileInfo data = new FileInfo(pathContentString);               
             fileName = pathContent;
             fileNameLength = fileName.Length;
             size = (int)data.Length;
             content = File.ReadAllBytes(pathContentString);

             BinaryWriter writer = null;
             

                try
                {
                    

                    writer = new BinaryWriter(new FileStream(importPath, FileMode.Create));
                    
                    writer.Write(fileNameLength);
                    writer.Write(fileName);
                    writer.Write(size);
                    writer.Write(content);
                    writer.Close();
                }
                finally
                {
                    if(writer != null)
                    writer.Close();


                }
             Console.WriteLine("Files copied successfully");

             Console.Read();
             Console.ReadKey();    
         }
         
    }
}
