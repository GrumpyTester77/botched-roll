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
            //Create a new file
            string path = @"C:\Users\Spike\Desktop\Programming Learning\C#Programs\C#Program\ZipIt\Test Data\CombinedData.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("File already Exists: " + path);
            }
            else 
            {
                FileStream newFile = File.Create(path);
                Console.WriteLine("File Created: " + path);
                
            }
            Console.ReadKey();

            //Import Function
            //copy data from exixting file to newly created file
            string content = File.ReadAllText("C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\Test Data 1.txt");
            string filePathInfo = "C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\Test Data 1.txt";
            FileInfo data = new FileInfo(filePathInfo);
            var size = data.Length;

            string contentOne = File.ReadAllText("C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\Test Data 2.txt");
            string filePathInfoOne = "C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\Test Data 2.txt";
            FileInfo dataOne = new FileInfo(filePathInfoOne);
            var sizeOne = data.Length;

            File.WriteAllText(@"C:\Users\Spike\Desktop\Programming Learning\C#Programs\C#Program\ZipIt\Test Data\CombinedData.txt", content + "\r\n" + "Length of file is: " + size + "\r\n" + contentOne + "\r\n" + "Length of file is: " + size);
            Console.WriteLine("File copied successfully");
            Console.Read();
            
        }
    }
}
