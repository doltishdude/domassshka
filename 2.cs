// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
namespace homework_task_3;

internal class ProjectBase
{
    static void Main(string[] args)
    {
        float x = float.Parse(Console.ReadLine());

        Console.WriteLine($"{x / 100} - число полных метров");

    }

}

