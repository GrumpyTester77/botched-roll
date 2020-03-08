using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ZipIt
{
    class zipFile
    {

        public static void readFilename(string filePath, string file, long size, BinaryWriter dataWriter)
        {

            byte[] fileName = null;
            int fileNameLength = 0;
            
            //assigning the data ready to copy

            fileName = Encoding.ASCII.GetBytes(file);
            fileNameLength = fileName.Length;

            zipFile.writeFilename(fileNameLength, fileName, size, dataWriter);

        }

        public static void writeFilename(int fileNameLength, byte[] fileName, long size, BinaryWriter dataWriter)
        {
            
            //copies the filename length, filename and size of data in bytes to the file
             {

                 dataWriter.Write(fileNameLength);
                 dataWriter.Write(fileName);
                 dataWriter.Write(size);
                 
             }



        }

        public static void extractFile(string filePath, string file,string fileOutputPath, BinaryReader fileReader)
        {

            //Extracts the data from the zipped file to a newly created file with the original filename
            byte[] pathContent = Encoding.ASCII.GetBytes(filePath);

            long size = fileReader.ReadInt64();

            BinaryWriter dataWriter = new BinaryWriter(new FileStream(fileOutputPath, FileMode.Create));

            fileUtils.appendToFile(fileReader, dataWriter, size);

            dataWriter.Close();
        }

        public static void importFile(string filePath,string file,BinaryWriter dataWriter,BinaryReader fileReader)
        {
            //imports filename length, filename , size of data in bytes and the data to the file
            byte[] pathContent = Encoding.ASCII.GetBytes(filePath);

            FileInfo data = new FileInfo(filePath);
            long size = data.Length;

            zipFile.readFilename(filePath, file, size, dataWriter);

            fileUtils.appendToFile(fileReader, dataWriter, size);

            dataWriter.Close();

        }
    }
}
