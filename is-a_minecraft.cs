// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

internal class Project1Base
{
    static void Main(string[] args)
    {
        Character[] characters = { new Character(40 + "") };
        foreach (var character in characters)
        {
            character.PrintCharacterInfo();
        }
        Enemy creeper = new Enemy(11);
       
        Enemy.CreeperDamage();
        Console.ReadLine();
    }
}
class Character
{
    protected int Health;
    public string Name;
    protected int Damage;
    public Character(int Health, string Name, int Damage)
    {
        this.Health = Health;
        this.Name = Name;
        this.Damage = Damage;
    }
    public void PrintCharacterInfo() 
    {
        Console.WriteLine($"{Name} HP { Health}");
    }
    
}
class NPC : Character
{
    public NPC( int HP,string NameOfCharacter, int Damage): base(HP,NameOfCharacter,Damage)
    {
    }
}
class Enemy : Character
{
    public Enemy(int HP, string NameOfCharacter, int Damage) : base(HP, NameOfCharacter, Damage) 
    {
    }
}
class Creeper : Enemy
{
    public Creeper (int HP, string NameOfCharacter, int Damage) : base(HP, NameOfCharacter, Damage)
    {
       
    }
    public void CreeperDamage (int damage)
    {
        Console.WriteLine("наносит урон" + damage);
    }
   
}
