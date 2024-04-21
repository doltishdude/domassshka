using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace maxvalue_massive_task;

internal class Class1
{
    static void Main(string[] args)
    {
        int[] numbers = { 12, 25, 8, 44, 51, };
        int maxValue = numbers.Max<int>();


        for (int i = 0; i < numbers.Length; i++)
        {
            // это штоб перед еденицей пробела не было
            if (numbers[i] == 12)
                Console.Write(numbers[i]);
            else
                Console.Write(" " + numbers[i]);

        }

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n" + maxValue);
        Console.ReadLine();
    }
}