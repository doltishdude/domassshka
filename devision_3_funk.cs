// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

internal class Project1Base
{
    static void Main(string[] args)
    {

        Func(0);
        int number2 = Func(0);
        int arraysum = 0;

        Console.WriteLine(number2);


        int[] arraynumbers = { 2, 11, 25, 30, 24, 12, };


        for (int i = 0; i < arraynumbers.Length; i++)
        {

            if (arraynumbers[i] % 3 == 0)
            {

                arraysum += arraynumbers[i];

            }
        }
        Console.WriteLine(arraysum);
        Console.ReadLine();
    }

    static int Func(int arraysumm)

    { return arraysumm; }

}

