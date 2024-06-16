// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.IO;


internal class Project1Base
{
    static void Main(string[] args)
    {

        Student uchenik = new Student(0);
        Console.ReadLine();
    }
}
class Student
{
    public string Name;
    public Student(string studentName)
    { Name = studentName; }
   
    public int Age;
    public Student(int age)
    {
        Age = age;
    }
  
    public float Score;
    public Student(float score)
    {
        Score = score;
       
        if (Score > 4.5)
        {
            Console.WriteLine("отлично");
        }
        if ( Score ==4)
        {
            Console.WriteLine("хорошо");
        } 
        if (Score <3)
        {
            Console.WriteLine("неудовлетворительно");
        }

    }
        public void Print() { Console.WriteLine($"{Name} {Age} {Score}"); }
}