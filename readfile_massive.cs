// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.IO;
namespace aboba
{
    internal class Project1Base
    {
        static void Main(string[] args)
        {
            string[] textfile = File.ReadAllLines("AAA2.txt");
            char[,] drawing = new char[textfile.Length, textfile.Length];
            
            for (int i = 0; i < drawing.GetLength(0); i++) 
            {
                for (int j = 0; j < drawing.GetLength(1); j++) 

                { 
                    drawing[ j, i ] = textfile [ i] [j ];
                    Console.Write(drawing[ j, i ] );
                
                }

                Console.WriteLine();
            
            }

            Console.ReadLine();
        }
    }
}