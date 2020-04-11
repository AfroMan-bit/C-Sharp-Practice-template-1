using System;

namespace Things.Models
{

    class Bird : IVocalizable
    {

        public string Name {get;set;}

        public Bird(string name)
        {
            Name = name;
        }

        public void MakeNoise()
        {
            Console.WriteLine("Chirp chirp!");
        }

    }
}