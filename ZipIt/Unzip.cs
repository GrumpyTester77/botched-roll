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
        public static void unzipFiles()
        {
            string fileUnzipLocation;
            string fileExport;
            Console.WriteLine("Please enter the path and filename of the file you want to unzip: ");
            fileExport = Console.ReadLine();
            Console.WriteLine("Please enter the path where you want to unzip the files to: ");
            fileUnzipLocation = Console.ReadLine();

            string fileOutput = fileUnzipLocation;


            if (File.Exists(fileExport))
            {


                BinaryReader fileReader = new BinaryReader(new FileStream(fileExport, FileMode.Open));

                int fileNameLength = fileReader.ReadInt32();
                byte[] buffer = new byte[fileNameLength];
                int bytesread = fileReader.Read();
                string fileName = buffer.ToString();
                int fileLength = fileReader.ReadInt32();
                byte[] bufferLength = new byte[fileLength];
                fileReader.Read();

                try
                {
                    StreamWriter fileWriter = new StreamWriter(fileOutput + "/" + fileName);
                    fileWriter.Write(buffer);
                }

                finally 
                {
                    StreamWriter fileWriter = new StreamWriter(fileOutput + "/" + fileName);
                    fileWriter.Close();
                }

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}