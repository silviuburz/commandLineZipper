using System;
using System.IO;
using System.IO.Compression;


namespace commandLineZipper
{
    class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(args[0]))
            {
                Console.WriteLine("Please provide a folder name");
            }
            else
            {
                ZipFile.CreateFromDirectory(Path.Combine(Environment.CurrentDirectory, args[0]), Path.Combine(Environment.CurrentDirectory, args[0]) + ".zip");
            }
        }
    }
}
