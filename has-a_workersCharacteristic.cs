// See https://aka.ms/new-console-template for more information
internal class Project1Base
{
    static void Main(string[] args)
    {
        Person worker1 = new Person("Чехов А.П.");
        Job job1 = new Job("медик", 50000);
        Person worker2 = new Person("Маяковский В.В.");
        Job job2 = new Job("маркетолог", 70000);
        Person worker3 = new Person("Гоголь Н.В.");
        Job job3 = new Job("секретарь", 20000);
        
        worker1.PrintPersonInfo();  
        job1.PrintPersonInfo();
        worker2.PrintPersonInfo();
        job2.PrintPersonInfo();
        worker3.PrintPersonInfo();
        job3.PrintPersonInfo();

        Console.ReadLine();
    }
}
class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public void PrintPersonInfo()
    {
        Console.Write($"{Name}");
    }
}

class Job
{
    public string Jobb { get; private set; }
    public int Pay { get; private set; }
    public Job(string job, int pay)
    {
        Jobb = job;
        Pay = pay;

    }
    public Person personName;
    public void PrintPersonInfo()
    {
        Console.WriteLine($"{personName} - {Jobb} с зарплатой {Pay}");
    }
}