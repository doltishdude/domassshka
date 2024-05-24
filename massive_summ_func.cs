// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

internal class Project1Base
{
    static void Main(string[] args)
    {
        int Arraysumm;
         OutSumm (out Arraysumm);
        
       
        Console.WriteLine(Arraysumm);

       
       static int OutSumm( out int Arraysumm);
        
        {
            Arraysumm = 0;
            int[] arraynumbers = { 2, 11, 25, 30, 24, 12, };

            for (int i = 0; i < arraynumbers.Length; i++)
            {

                    Arraysumm += arraynumbers[i];

            }

        }
            Console.ReadLine();
        
    }
}

