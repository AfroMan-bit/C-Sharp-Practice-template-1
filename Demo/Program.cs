using System;

using System.Collections.Generic;

using Things.Models;


namespace Things
{
    class Program
    {
        static void Main(string[] args)
        {

            // Person Ben = new Student("Ben", 3);
            // Student Wale = new Student("Wale", 2);
            // Wale.MakeNoise();
            // Student newBen = (Student) Ben;
            // newBen.MakeNoise();
            // Bird Tweety = new Bird("tweety");
            // Tweety.MakeNoise();

            // OR 

            // Person Ben = new Student("Ben", 3);
            // Student Wale = new Student("Wale", 2);
            // Student newBen = (Student) Ben;
            // Bird Tweety = new Bird("tweety");
            // List<IVocalizable> someRoom = new List<IVocalizable>();
            // someRoom.Add(newBen);
            // someRoom.Add(Wale);
            // someRoom.Add(Tweety);
            // foreach(var thing in someRoom)
            // {
            //     thing.MakeNoise();
            // }

            // OR

            Person Ben = new Student("Ben", 3);
            Student Wale = new Student("Wale", 2);
            Student newBen = (Student) Ben;
            Bird Tweety = new Bird("tweety");
            IVocalizable[] someRoom = new IVocalizable[]{
                newBen,
                Wale,
                Tweety
            };
            
            foreach(var thing in someRoom)
            {
                thing.MakeNoise();
            }

        }

    }
}
