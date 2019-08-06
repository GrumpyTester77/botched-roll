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
            string fileUnzipLocation;
            string fileExport;
            Console.WriteLine("Please enter the path and filename of the file you want to unzip: ");
            fileExport = Console.ReadLine();
            Console.WriteLine("Please enter the path where you want to unzip the files to: ");
            fileUnzipLocation = Console.ReadLine();
            

            if(File.Exists(fileExport))
            {
                
                
                BinaryReader fileReader = new BinaryReader(new FileStream (fileExport, FileMode.Open));

                byte[] buffer = new byte[4];
                int bytesRead;
                while((bytesRead = fileReader.Read(buffer, 0, buffer.Length)) > 0) {
                FileStream.Write(buffer, 0, bytesRead);
                
                


               
            }
            Console.ReadKey();
        }
    }
}
