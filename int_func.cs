// See https://aka.ms/new-console-template for more information

internal class Project1Base
{
    static void Main(string[] args)
    {

        int number = 0;
        Returndevision(ref number);
        Console.WriteLine(number);
        Console.ReadLine();
    }
    static int Returndevision(ref int number)
    {
        int a = 15;
        int b = 3;
        int div = a % b;
        return number = div;
        //апочему 0 выводит? Т-Т
    }
}
