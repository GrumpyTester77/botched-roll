using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ZipIt
{
    class FileUtils
    {
        public static void appendToFile(BinaryReader fileReader, string filePath, long toRead)
        {

            BinaryWriter dataWriter = null;
            dataWriter = new BinaryWriter(new FileStream((filePath), FileMode.Create));
            //Data to append to the new file                       

            FileUtils.appendToFile(fileReader, dataWriter, toRead);

        }

        public static void appendToFile(BinaryReader fileReader, BinaryWriter dataWriter, long toRead)
        {
            //loops through the data 20 bytes at a time coping the data to the buffer then writing to the file
            try
            {

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
                if (dataWriter != null)
                    dataWriter.Close();

            }
        }


        public static void openFileToRead(string filePath, string fileOutput, string file)
        {
            BinaryReader fileReader = new BinaryReader(new FileStream(filePath, FileMode.Open, FileAccess.Read));


            long position = fileReader.BaseStream.Position;

            long fileLength = fileReader.BaseStream.Length;

            do 
                {

                    int fileNameLength = fileReader.ReadInt32();
                    byte[] buffer = fileReader.ReadBytes(fileNameLength);
                    string fileName = Encoding.UTF8.GetString(buffer);
                    string fileOutputPath = fileOutput + fileName;
 
                    ZipFile.extractFile(filePath, file, fileOutputPath, fileReader);

                    position = fileReader.BaseStream.Position;
            }
            while (position != fileLength);

            if (fileReader != null)
            {
                fileReader.Close();
            }
        }
    }
}
