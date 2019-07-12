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
            var size = data.Length;

            string contentOne = File.ReadAllText("C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\Test Data 2.txt");
            string filePathInfoOne = "C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\Test Data 2.txt";
            FileInfo dataOne = new FileInfo(filePathInfoOne);
            var sizeOne = data.Length;

            File.WriteAllText(importPath, size + "\r\n" + content + "\r\n" + size + "\r\n" + contentOne);
            Console.WriteLine("Files copied successfully");

            Console.Read();
            Console.ReadKey();

            
         }

         
    }
}
