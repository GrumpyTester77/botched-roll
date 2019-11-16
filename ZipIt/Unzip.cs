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
            string fileUnzipLocation;
            string fileExport;
            Console.WriteLine("Please enter the path and filename of the file you want to unzip: ");
            fileExport = Console.ReadLine();
            Console.WriteLine("Please enter the path where you want to unzip the files to: ");
            fileUnzipLocation = Console.ReadLine();

            string fileOutput = fileUnzipLocation;
            


            if (File.Exists(fileExport))
            {

                //read the file and get back the filename to create the new file to copy data to.
                BinaryReader fileReader = new BinaryReader(new FileStream(fileExport, FileMode.Open));
                
                int fileNameLength = fileReader.ReadInt32();
                byte[] buffer = new byte[fileNameLength];
                int singleByte = fileReader.ReadByte();
                int bytesRead = fileReader.Read(buffer, 0 , fileNameLength);
                string bytesConverted = Encoding.UTF8.GetString(buffer, 0, fileNameLength); 
                string fileName = bytesConverted;
                Console.WriteLine(bytesConverted);
                Console.WriteLine("Filename is:" + fileName);
                int fileLength = fileReader.ReadInt32();
                byte[] bufferLength = new byte[fileLength];
                fileReader.Read();

                try
                {
                    
                    StreamWriter fileWriter = new StreamWriter(fileOutput + fileName);
                    fileWriter.Write(buffer);
                    fileWriter.Close();
                }

                finally 
                {
                    StreamWriter fileWriter = new StreamWriter(fileOutput + fileName);
                    fileWriter.Close();
                }

                while (fileLength < 0)
                {
                    fileReader.Read();
                }


                //file size of data to append to the new file
                long size = fileReader.ReadInt32();
                int Size = Convert.ToInt32(size);
                byte[] data = new byte[Size];
                //int aByte = fileReader.ReadByte();
                int readBytes = fileReader.Read(data , 0 , Size);
                long toRead = Size;
                fileReader.Read();

                byte[] dataBuffer = new byte[0];

                while (toRead > 0) 
                {
                    
                    if (toRead > 20) 
                    {
                        dataBuffer = new byte [20];
                        toRead = toRead - 20;

                    }
                    else
                    {
                        dataBuffer = new byte [toRead];
                        toRead = 0;
                    }
                    
                    fileReader.Read();
                    StreamWriter fileWriter = new StreamWriter(fileOutput + fileName);
                    fileWriter.Write(dataBuffer);
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