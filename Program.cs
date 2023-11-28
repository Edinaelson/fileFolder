using System;
using System.IO;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] diretorios = Directory.GetDirectories("c:\\");
            
            Console.WriteLine("Diretórios:");
            foreach (string dir in diretorios)
            {
                Console.WriteLine(dir);
            }
        }
    }
}