using System;

namespace Basics.cs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // C#
            const byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;            // double by default
            const float acceleration = 9.800F;      // float by tag
            float mass = 14.6F;
            double distance = 129.763001D;          // double by tag
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            //const char = "\\u{222B}";      // escape character needs double
            int age = 0;
            string greeting = "Hello";
            string name = "Karen";


            if (sample1 == sample2) Console.WriteLine("The samples are equal.");
            else Console.WriteLine("The samples are not equal.");

            if (heartRate >= 40 && heartRate <= 80) Console.WriteLine("Heart rate is normal.");
            else Console.WriteLine("Heart rate is not normal");

            if (deposits >= 100000000) Console.WriteLine("You are exceedingly wealthy.");
            else Console.WriteLine("Sorry you are so poor.");

            float force = mass * acceleration;
            Console.WriteLine("force = {0} and {1} is the distance", force, distance);

            if (lost == true && expensive == true) Console.WriteLine("I am really sorry! I will get the manager.");

            if (lost == true && expensive == false) Console.WriteLine("Here is coupon for 10% off.");

            switch(choice){
                case 1 : 
                    Console.WriteLine("You chose 1.");
                    break;
                case 2 : 
                    Console.WriteLine("You chose 2.");
                    break;
                case 3 :
                    Console.WriteLine("You chose 3.");
                    break;
                default :
                    Console.WriteLine("You made an unknown choice");
                    break;
                    
            }

            for (int i = 5; i < 11; i++)
            {
                Console.WriteLine("i={0}", i);
            }

            while (age < 6){
                Console.WriteLine("age = {0}", age);
                age++;
            }
            Console.WriteLine("{0} {1}!", greeting, name);

        }}
}
