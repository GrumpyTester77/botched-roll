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
            string content = File.ReadAllText("C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\Test Data 1.txt");
            string filePathInfo = "C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\Test Data 1.txt";
            FileInfo data = new FileInfo(filePathInfo);
            string fileName = Path.GetFileName(filePathInfo);
            int fileNameLength = fileName.Length;
            var size = data.Length;

            string contentOne = File.ReadAllText("C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\Test Data 2.txt");
            string filePathInfoOne = "C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\Test Data 2.txt";
            FileInfo dataOne = new FileInfo(filePathInfoOne);
            string fileNameOne = Path.GetFileName(filePathInfoOne);
            int fileNameLengthOne = fileName.Length;
            var sizeOne = data.Length;

            using (StreamWriter writer = new StreamWriter(importPath))
            {
                writer.WriteLine(fileNameLength + " " + fileName + " " + size + "\r\n" + content + "\r\n" + fileNameLength + " " + fileNameOne + " " + size + "\r\n" + contentOne);
            }
            
            Console.WriteLine("Files copied successfully");

            Console.Read();
            Console.ReadKey();

            
         }

         
    }
}
