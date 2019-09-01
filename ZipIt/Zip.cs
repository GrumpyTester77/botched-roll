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
             string content = null;
             string filePathInfo = null;
             string fileName = null;
             int fileNameLength = 0;
             long size = 0;



            //while (addFile == "yes")
            //{

                Console.WriteLine("Please enter path of file to zip: ");
                content = Console.ReadLine();
                filePathInfo = content;
                FileInfo data = new FileInfo(filePathInfo);
                fileName = Path.GetFileName(filePathInfo);
                fileNameLength = fileName.Length;
                size = data.Length;
                try
                {
                    BinaryWriter writer = new BinaryWriter(new FileStream(importPath, FileMode.Open));

                    writer.Write(fileNameLength);
                    writer.Write(fileName);
                    writer.Write(size);
                    writer.Write(content);
                }
                finally
                {
                    BinaryWriter writer = new BinaryWriter(new FileStream(importPath, FileMode.Open));
                    writer.Close();
                }
                      
                //Console.WriteLine("Do you want to add another file to the zip? please type (yes/no)");
                //string answer = Console.ReadLine();
                //answer = addFile;

                //if (addFile == "no")
                //{
                //    break;
                //}




            //}
            
            Console.WriteLine("Files copied successfully");

            Console.Read();
            Console.ReadKey();

            
         }

         
    }
}
