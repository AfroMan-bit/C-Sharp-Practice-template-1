using System;

// import Models like this below 
using FirstCSharp.Models;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)

        // this code below will print out "Hello World" when you type dotnet run in the terminal. Injecting a string into the console.
        // {
        //     Console.WriteLine("Hello World!");
        // }


        // this code below will print out "Coding Dojo" 
        // {
        //     string place = "Coding Dojo";
        //     Console.WriteLine(place);
        // }

        // this code below will print out "Hello Coding Dojo" 
        // {
        //     string place = "Coding Dojo";
        //     //Interpolated string below, note the $
        //     Console.WriteLine($"Hello {place}");
        // }


        // THIS IS HOW TO REFERENCE Person.cs file in Models folder 
        {
            Console.WriteLine("Hello World!");
            Person instructor = new Person("Ben",29);
            instructor.Age = 14;
            Console.WriteLine(instructor.Age);
            instructor.SayName();


            Ninja ben = new Ninja("Ben",29,500,300);
            ben.SayName();
        }
        
    }
}
