// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
namespace tablica_9;

internal class ProjectBase
{
    static void Main(string[] args)
    {
        int a = 9;
        float b = 0;
        float c;

        for (int i = 10; i > 0; i--)
        {
          if (i>0)
            b++;
            c = a * b;

            Console.WriteLine( a + "*" + b + "=" + c);
            
        }




        Console.ReadLine();
    }


}


