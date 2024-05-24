// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

namespace aboba
{
    internal class Project1Base
    {
        static void Main(string[] args)
        {
            float s = 10;
            float p = 20.5f;
            int k = 1;



            while (s <= 200)
            {
                s += (s * p) / 100;

                k++;


                if (s > 200)
                {
                    Console.WriteLine("суммарный пробег лыжника привысит 200 км через " + k + " дней"); Console.WriteLine( "сууммарный пробег: " + s + "км"); break;
                }


            }

            Console.ReadLine();
        }
    }
}



