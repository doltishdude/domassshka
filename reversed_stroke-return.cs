// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

namespace shkwarki;

internal class Project1Base
{
    static void Main(string[] args)
    {

        Func("эта строка написана задом на перед");
        string word2 = Func("эта строка написана задом на перед");

        char[] charArray = word2.ToCharArray();
        Array.Reverse(charArray);

        Console.WriteLine(charArray);

        Console.ReadLine();
    }

    static string Func(string word)
    { return word; }

}

