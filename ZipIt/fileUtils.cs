using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ZipIt
{
    class fileUtils
    {
        public static void appendToFile(BinaryReader fileReader, string filePath, long toRead)
        {

            BinaryWriter dataWriter = null;
            dataWriter = new BinaryWriter(new FileStream((filePath), FileMode.Create));
            //Data to append to the new file                       

            fileUtils.appendToFile(fileReader, dataWriter, toRead);
           
        } 
        
        public static void appendToFile(BinaryReader fileReader, BinaryWriter dataWriter, long toRead)
        {
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
                if(dataWriter != null)
                   dataWriter.Close();
                if (fileReader != null)
                    fileReader.Close();
            }
        }
        
    }
}
