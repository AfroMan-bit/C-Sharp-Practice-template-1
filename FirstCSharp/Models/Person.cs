// import System like this below. we can also auto add this by clicking on Console and then press ctrl + .
using System;

namespace FirstCSharp.Models
{
    public class Person
    {
        public string Name;
        protected int age;

        public Person(string name, int _age)
        {
            Name = name;
            age = _age;
        }

        public Person(string name)
        {
            Name = name;
            age = 0;
        }

        // this code below ensures the variable "age" is publicly accessible using a "get" and "set" in the Program.cs even if it is protected 
        public int Age{
            get{
                return age;
            }
            set {
                // age = value;

                // OR
                if(value <= age)
                {
                    Console.WriteLine("you cant go backwards in age.");
                }
                else
                { 
                    age = value;
                }
            }
        }

        public virtual void SayName()
        {
            Console.WriteLine($"Hello my name is {Name}");
        }
    }
}