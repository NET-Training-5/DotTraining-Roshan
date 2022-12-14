using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.NetworkInformation;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //checking file exists or not

            //string path = @"D:\\data.txt";  //either use @ at first   or use \\   @ is called varbatim literal this or
            //string path = @"D:\data.txt";  //either use @ at first   or use \\   @ is called varbatim literal this

            //if(File.Exists(path) )
            //{
            //    Console.WriteLine("yes there is a file");
            //}
            //else
            //{
            //    Console.WriteLine("file not found");
            //}
            //Console.ReadLine();





            //Reading data form text file


            //if (File.Exists(path))
            //{
            //    Console.WriteLine("yes there is a file");
            //    string data = File.ReadAllText(path);
            //    Console.WriteLine(data);
            //}
            //else
            //{
            //    Console.WriteLine("file not found");
            //}
            //Console.ReadLine(); 



            // copying file  first version of file.copy

            //string path = "D:\\data.txt";
            //string path2 = "D:\\Data\\data2.txt";

            //File.Copy(path, path2);
            //Console.ReadLine();



            // overriding second version
            // string path = "D:\\data2.txt";
            //  string path2 = "D:\\data2.txt";
            // //File.Copy(path, path2, true);
            // string data = File.ReadAllText(path2);
            // Console.WriteLine(data);

           
            // Console.ReadLine();






        }
    }
}
