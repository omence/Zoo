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
            base.Feed();
        }

        /// <summary>
        /// prompts
        /// </summary>
        public override void CleanCage()
        {
            base.CleanCage();
        }

        public override void Fly()
        {
            Console.WriteLine("The Eagle is flying");
        }
    }
}
