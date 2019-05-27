using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace ZipIt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new file
            string path = @"C:\Users\Spike\Desktop\Programming Learning\C#Programs\C#Program\ZipIt\Test Data\CombinedData.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("File all Ready Exists: " + path);
            }
            else 
            {
                FileStream newFile = File.Create(path);
                Console.WriteLine("File Created: " + path);
                
            }
            Console.ReadKey();

            //copy data from exixting file to newly created file
            
            File.Copy(@"C:\Users\Spike\Desktop\Programming Learning\C#Programs\C#Program\ZipIt\Test Data\Test Data 1.txt", @"C:\Users\Spike\Desktop\Programming Learning\C#Programs\C#Program\ZipIt\Test Data\CombinedData.txt");
            Console.WriteLine(File.ReadAllText(@"C:\Users\Spike\Desktop\Programming Learning\C#Programs\C#Program\ZipIt\Test Data\Test Data 1.txt"));
            Console.WriteLine(File.ReadAllText(@"C:\Users\Spike\Desktop\Programming Learning\C#Programs\C#Program\ZipIt\Test Data\CombinedData.txt"));
            Console.Read();
            
            
            
        }
    }
}
