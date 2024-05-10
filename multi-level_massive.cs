// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

namespace aboba
{
    internal class Project1Base
    {
        static void Main(string[] args)
        {
            char[,] words = new char[,] {


            { 'a', 'b', 'c'},
            {'d', 'e', 'f'},
            {'g' , 'k', 'l'}
           
            };
            
            for ( int i =0 ; i < words.GetLength(0); i++)
            {
                for ( int j =0; j < words.GetLength(0); j++ )
                {
                    Console.Write(words[i,j] + " ");

                }  
                Console.WriteLine();
            }

           Console.ReadLine();
        }
    }
}

