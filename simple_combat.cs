// See https://aka.ms/new-console-template for more information

internal class Class1
{
    static void Main(string[] args)
    {
        float health = 100;
        int damage = 1;

        float health2 = 150;
        int damage2 = 6;

        while (health > 0 && health2 > 0)
        {

                Console.WriteLine("player " + health + " player2 " + health2);
            health2 = health2 - damage;
            health = health - damage2;
            
        }
        if (health < health2)
        {
            Console.WriteLine( "player 2 win");
        }
        else
        {
            Console.WriteLine(health + "player 1 win");
        }

        Console.ReadLine();
    }

}
    

       
