using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class BirdsNoFlyFlamingo : BirdsNoFly, ISwim, ICanAlsoFly
    {
        public bool IsPink { get; set; } = true;


        /// <summary>
        /// Method of cleaning feathers
        /// </summary>
        public override string CleanFeathers()
        {
            Console.WriteLine("The flamingo cleans self with beak");

            return "The flamingo cleans self with beak";
        }

        /// <summary>
        /// Running
        /// </summary>
        public override string Run()
        {
            Console.WriteLine("Flamingo is running");

            return "Flamingo is running";
        }
        /// <summary>
        /// Standing on one leg
        /// </summary>
        public string StandsOnOneLeg()
        {
            Console.WriteLine("The flamingo is standing on one leg");

            return "The flamingo is standing on one leg";
        }

        /// <summary>
        /// Makes swim
        /// </summary>
        public string ICanSwim()
        {
            Console.WriteLine("I'm swimming!");

            return "I'm swimming!";
        }

        /// <summary>
        /// Makes fly
        /// </summary>
        public string ICanFly()
        {
            Console.WriteLine("I'm Flying");

            return "I'm Flying";
        }
    }
}
