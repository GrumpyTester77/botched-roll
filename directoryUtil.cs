using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ZipIt
{
    class directoryUtil
    {

         public static void directoryCreateListOfFiles(string zipPath, string importPath)
         {
             bool existsAndIsDirectory = Directory.Exists(zipPath);

             if (existsAndIsDirectory == true)
             {
                 DirectoryInfo dir_info = new DirectoryInfo(zipPath);
                 FileInfo[] dirs = dir_info.GetFiles();

                 List<string> fileList = new List<string>();

                 foreach (FileInfo files in dirs)
                 {

                     fileList.Add(files.Name);
                 }

                 directoryUtil.openAndAppendFilesFromDirectoryList(fileList, zipPath, importPath);
             }
             else
             {
                 string file = Path.GetFileName(zipPath);
                 BinaryReader fileReader = new BinaryReader(new FileStream(zipPath, FileMode.Open));
                 BinaryWriter dataWriter = new BinaryWriter(new FileStream(importPath, FileMode.Append));

                 zipFile.importFile(zipPath, file, dataWriter, fileReader);
             }
         }

         public static void openAndAppendFilesFromDirectoryList(List<string> fileList, string zipPath, string importPath)
         {
             try
             {
                 
                    foreach (string name in fileList)
                 {

                     string file = name;
                     string path = zipPath + name;
                     BinaryReader fileReader = new BinaryReader(new FileStream(path, FileMode.Open));
                     BinaryWriter dataWriter = new BinaryWriter(new FileStream(importPath, FileMode.Append));

                     zipFile.importFile(path, file, dataWriter, fileReader);
                 }
             }
             catch (Exception e)
             {
                 Console.WriteLine("The process failed: {0}", e.ToString());
             }
         }
    }
}
