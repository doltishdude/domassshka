// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

namespace password;

internal class Project1Base
{
    static void Main(string[] args)
    {
        int a = 12345;
        int popitki;

        for (int i = 5; i > 0; i--)
        {
            if (Convert.ToInt32(Console.ReadLine()) == 12345)
            {
                Console.WriteLine("зашел");
                break;
                
            }
            else
            {
                Console.WriteLine ("error" );
                popitki = i;
            }
            if (popitki == 1)
            {
                Console.WriteLine("попытки закончились");
            }
        }

        Console.ReadLine();
    }

}




