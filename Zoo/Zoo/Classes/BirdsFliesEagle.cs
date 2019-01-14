using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class BirdsFliesEagle : BirdFlies
    {
        /// <summary>
        /// prompts feeding of eagle
        /// </summary>
        public override void Feed()
        {
            Console.WriteLine("Feed the Eagle");
        }

        /// <summary>
        /// prompts
        /// </summary>
        public override void CleanCage()
        {
            Console.WriteLine("Clean the Eagle's cage");
        }

        public override void Fly()
        {
            Console.WriteLine("The Eagle is flying");
        }
    }
}
