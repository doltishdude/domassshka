// See https://aka.ms/new-console-template for more information
internal class Project1Base
{
    static void Main(string[] args)
    {
        Animal[] animals = { new Animal("cat"), new Animal("dog"), new Animal("bird") };
       foreach (var animal in animals)
        {
            animal.Print();
        }
        Console.ReadLine();
    }
}
class Animal
{
    public string Name;
    public Animal(string name)
    {
        Name = name;
    }
    public void Print()
    {
        Console.WriteLine("animal: " + Name);
    }

}