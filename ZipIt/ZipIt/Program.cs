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
            string importPath;
            Console.WriteLine("To create the file, Please enter the path and filename: ");
            importPath = Console.ReadLine();

            //string path = @"C:\Users\Spike\Desktop\Programming Learning\C#Programs\C#Program\ZipIt\Test Data\CombinedData.txt";

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

            //Import Function
            //copy data to newly created file
            string content = File.ReadAllText("C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\Test Data 1.txt");
            string filePathInfo = "C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\Test Data 1.txt";
            FileInfo data = new FileInfo(filePathInfo);
            var size = data.Length;

            string contentOne = File.ReadAllText("C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\Test Data 2.txt");
            string filePathInfoOne = "C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\Test Data 2.txt";
            FileInfo dataOne = new FileInfo(filePathInfoOne);
            var sizeOne = data.Length;

            File.WriteAllText(importPath, content + "\r\n" + "Length of file is: " + size + "\r\n" + contentOne + "\r\n" + "Length of file is: " + size);
            Console.WriteLine("Files copied successfully");
            Console.Read();
            
            Console.ReadKey();

            //Export Function
            //Copy data from newly created file out into seperate files
            string exportPath;
            Console.WriteLine("Please enter the path and filename of the file you want to export: ");
            exportPath = Console.ReadLine();

            if(File.Exists(exportPath))
            {

                foreach (var line in File.ReadLines(exportPath))
                {
                    if (line != "Length of file is: ")
                    {
                        File.Create("C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\new1.txt");
                        File.AppendText("C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\new1.txt");
                    }
                    else
                    {
                        File.Create("C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\new2.txt");
                        File.AppendText("C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\new2.txt");
                    }
                }
            }
            Console.ReadKey();
            
        }
    }
}
