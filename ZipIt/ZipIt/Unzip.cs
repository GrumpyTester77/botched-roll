using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ZipIt
{
    class Unzip
    {

        //Unzip Function
            //Copy data from newly created file out into seperate files
        public static void unzipFiles(){
            string exportPath;
            Console.WriteLine("Please enter the path and filename of the file you want to unzip: ");
            exportPath = Console.ReadLine();
            

            if(File.Exists(exportPath))
            {

                foreach (var line in File.ReadLines(exportPath))
                {
                    if (line != "Length of file is: ")
                    {
                        //The next two commented out lines are what I was playing around with for the file paths

                        //string filePath = Path.GetFullPath("C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\");
                        //string result = Path();
                        Console.WriteLine("Temp file name is " + result);
                        FileStream newFile = File.Create(result);
                        newFile.Close();
                        File.AppendText(result);
                    }
                    else
                    {
                        string result = Path.GetFullPath("C:\\Users\\Spike\\Desktop\\Programming Learning\\C#Programs\\C#Program\\ZipIt\\Test Data\\");
                        Console.WriteLine("Temp file name is " + result);
                        FileStream newFile = File.Create(result);
                        newFile.Close();
                        File.AppendText(result);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
