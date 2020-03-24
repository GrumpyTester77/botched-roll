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
            
            Console.WriteLine("Please enter the path and filename of the file you want to unzip: ");
            string filePath = Console.ReadLine();
            string file = Path.GetFileName(filePath);

            Console.WriteLine("Please enter the path where you want to unzip the files to: ");
            string fileOutput = Console.ReadLine();

                if (File.Exists(filePath))
                {
                    //read the file and get back the filename to create the new file to copy data to.
                    byte position;
                    BinaryReader fileReader = new BinaryReader(new FileStream(filePath, FileMode.Open));
                    while ((position = fileReader.ReadByte()) != 0)
                    {

                        int fileNameLength = fileReader.ReadInt32();
                        byte[] buffer = fileReader.ReadBytes(fileNameLength);
                        string fileName = Encoding.UTF8.GetString(buffer);
                        string fileOutputPath = fileOutput + fileName;

                        zipFile.extractFile(filePath, file, fileOutputPath, fileReader);

                        
                    }
                    

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
    
