using System;

namespace Things.Models {

    public class Student : Person, IVocalizable
    {
        

        public int NumBelts {get;set;}

        public Student(string name, int numBelts) : base(name)
        {
            NumBelts = numBelts; 
        }

        public void MakeNoise()
        {
            Console.WriteLine($"{Name} cries in a corner ");
        }

    }
}