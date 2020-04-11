using System;
using HumanAndNinja.Models;

namespace HumanAndNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanClass Ben = new HumanClass("Ben");
            Console.WriteLine($"{Ben.Name} is losing his mind");
            Buffet firstBuffet = new Buffet();
            Console.WriteLine($"{Ben.Name} got a {firstBuffet.Serve().Name}");
            Ninja carol = new Ninja("Carol");
            Console.WriteLine($"{carol.Name} is a ninja!");
            carol.Eat(firstBuffet.Serve());
            carol.Eat(firstBuffet.Serve());
            carol.Eat(firstBuffet.Serve());
            carol.Eat(firstBuffet.Serve());
            Wizard ben = new Wizard("Ben", 17, 19);
            Ninja wale = new Ninja("Wale",17, 19, 150 );
            Samurai lola = new Samurai("Lola", 17, 19,80);
            ben.DisplayStats();
            wale.DisplayStats();
            lola.DisplayStats();
            // ben.Attack(wale);
            wale.Attack(ben);
            ben.DisplayStats();
            lola.Attack(wale);
            ben.Heal(wale);
            lola.Meditate();
            wale.Steal(ben);
        }
    }
}
