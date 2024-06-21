// See https://aka.ms/new-console-template for more information

internal class Project1Base
{
    static void Main(string[] args)
    {
        Adress adress = new Adress(12 , "чапаева");
        Person person = new Person("Андрей", adress);
        person.ShowPersonInfo();
        Console.ReadLine();
    }
}
 class Adress 
{ 
    public int House { get; private set; }
    public string Street { get; private set; }
    public Adress(int house, string street )
    {
        House = house;
        Street = street;
    } 
}
class Person
{
    public string Name { get; private set; }
    public Person(string name, Adress adress)
    {
        Name = name;
        _personAdress = adress;
       
    }
    private Adress _personAdress;

    public void ShowPersonInfo () {
        Console.WriteLine( $"человек {Name} живет на улице {_personAdress.Street}, в доме {_personAdress.House}");
    }
}