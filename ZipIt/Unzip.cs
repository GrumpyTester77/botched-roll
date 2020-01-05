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
                byte[] buffer = new byte[fileNameLength];
                //int singleByte = fileReader.ReadByte();
                int bytesRead = fileReader.Read(buffer, 0, fileNameLength);
                string bytesConverted = Encoding.UTF8.GetString(buffer, 0, fileNameLength);
                string fileName = bytesConverted;
                Console.WriteLine(bytesConverted);
                Console.WriteLine("Filename is:" + fileName);
                int fileLength = fileReader.ReadInt32();
                byte[] bufferLength = new byte[fileLength];
                
                //Data to append to the new file                
                int toRead = fileReader.Read();                      
                                       
                BinaryWriter dataWriter = null;
                try
                {
                    dataWriter = new BinaryWriter(new FileStream(Path.Combine(fileOutput, fileName), FileMode.Create));
                    byte[] dataBuffer = new byte[0];
                    
                    
                    while (toRead > 0)
                    {

                        if (toRead > 20)
                        {
                            dataBuffer = new byte[20];
                            
                            fileReader.Read(dataBuffer, 0, dataBuffer.Length);
                            dataWriter.Write(dataBuffer);
                            toRead = toRead - 20;
                        }
                        else
                        {
                            dataBuffer = new byte[toRead];
                            
                            fileReader.Read(dataBuffer, 0, dataBuffer.Length);
                            dataWriter.Write(dataBuffer);
                            toRead = 0;
                        }

                    }
                    
                }
                finally
                {
                    if (fileReader != null)
                    {
                        fileReader.Close();
                    }
                    if (dataWriter != null)
                    {
                        dataWriter.Close();
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