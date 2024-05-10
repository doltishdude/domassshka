// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.IO;
namespace a;

internal class Project1Base
{
    static void Main(string[] args)
    {

        Func(12);
        int number2= Func(12);

        Console.WriteLine(number2);

        Console.ReadLine();
    }

    static int Func (int number)
    {  return number + 10; }
        
}
