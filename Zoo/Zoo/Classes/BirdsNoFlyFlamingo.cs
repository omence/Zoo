using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class BirdsNoFlyFlamingo : BirdsNoFly, ISwim, ICanAlsoFly
    {
        public bool IsPink { get; set; } = true;

        public override string CleanFeathers()
        {
            Console.WriteLine("The flamingo cleans self with beak");

            return "The flamingo cleans self with beak";
        }

        public override string Run()
        {
            Console.WriteLine("Flamingo is running");

            return "Flamingo is running";
        }

        public string StandsOnOneLeg()
        {
            Console.WriteLine("The flamingo is standing on one leg");

            return "The flamingo is standing on one leg";
        }

        public string ICanSwim()
        {
            Console.WriteLine("I'm swimming!");

            return "I'm swimming!";
        }
        
        public string ICanFly()
        {
            Console.WriteLine("I'm Flying");

            return "I'm Flying";
        }
    }
}
