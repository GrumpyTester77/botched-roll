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
        //Copy data from newly created file out into seperate files.
        public static void unzipFiles()
        {
            string fileExport;
            Console.WriteLine("Please enter the path and filename of the file you want to unzip: ");
            fileExport = Console.ReadLine();
            Console.WriteLine("Please enter the path where you want to unzip the files to: ");
            string fileOutput = Console.ReadLine();

                if (File.Exists(fileExport))
                {
                    //read the file and get back the filename to create the new file to copy data to.
                    BinaryReader fileReader = new BinaryReader(new FileStream(fileExport, FileMode.Open));

                    int fileNameLength = fileReader.ReadInt32();
                    byte[] buffer = fileReader.ReadBytes(fileNameLength);
                    string fileName = Encoding.UTF8.GetString(buffer);
                    Console.WriteLine("Filename is:" + fileName);

                    long toRead = fileReader.ReadInt64();
                    Console.WriteLine("Filelength is:" + toRead);
                    string filePath = fileOutput + fileName;

                    fileUtils.appendToFile(fileReader, filePath, toRead);

                    {
                    if (fileReader != null)
                    {
                        fileReader.Close(); 
                    }
                    
                }

                }
                else
                {
                    Console.WriteLine("File does not exist.");
                    Console.ReadKey();
                }
           }
      }
}
    
