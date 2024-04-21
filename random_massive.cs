
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_massive;

internal class Class1
{
    static void Main(string[] args)
    {

        int[] array = new int[5];
        Random rand = new Random{ }; 
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(31);
            Console.Write($"{array[i]}" + " ");
        }
       
        Console.ReadLine();
    }
}



 