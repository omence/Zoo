using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class BirdsNoFlyFlamingo : BirdsNoFly
    {
        public bool IsPink { get; set; }

        public override void Feed()
        {
            base.Feed();
        }

        public override void CleanCage()
        {
            base.CleanCage();
        }

        public override void Run()
        {
            Console.WriteLine("Flamingo is running");
        }

        public string StandsOnOneLeg()
        {
            Console.WriteLine("The flamingo is standing on one leg");

            return "The flamingo is standing on one leg";
        }
    }
}
