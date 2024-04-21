using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomnumber
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int value;

            value = new Random().Next(0, 101) ;

            Console.WriteLine("угадайте число от 1 до 100");
            int number=0;
                
            while (value!=number) 
            {

                number = int.Parse(Console.ReadLine());

                if (value == number)
                {
                    Console.WriteLine("you win");
                   
                }

                else if (value < number)
                {
                    Console.WriteLine("возьми число поменьше");
                }

                else if (value> number)
                {
                    Console.WriteLine("возьми число побольше");
                }

                else
                {
                    Console.WriteLine(" try again ");

                }

            }

                Console.ReadLine();
        }
    } 
}
