// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

namespace aboba
{
    internal class Project1Base
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            while (numbers > 0)
            
            {
                numbers--;

                if (numbers % 2 == 0)
                {
                    Console.WriteLine(numbers);
                }
                if (numbers ==10) { break; }

                   



                

                
            }



            Console.ReadLine();
        }
    }
}

