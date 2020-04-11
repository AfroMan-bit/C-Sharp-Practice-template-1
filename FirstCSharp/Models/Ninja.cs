// import System like this below. we can also auto add this by clicking on Console and then press ctrl + .
using System;

namespace FirstCSharp.Models
{
    public class Ninja : Person
    {
        public int Speed;
        public int Dexterity;
        public int Strength;
        public Ninja(string name, int _age,int dex,int str) : base(name, _age)
        {
            Dexterity = dex;
            // Speed is set to default of "5" that is why there isnt "int spd" above 
            Speed = 5;
            Strength = str;
        }
        public override void SayName()
        {
            base.SayName();
            Console.WriteLine("I am a black belt ninja");
        }
    }
}