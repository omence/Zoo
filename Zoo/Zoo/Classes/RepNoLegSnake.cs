using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class RepNoLegSnake : RepNoLegs
    {
        public override bool Slithers { get; set; }

        public bool HasScales { get; set; }

        /// <summary>
        /// Prompts feeding of snake
        /// </summary>
        public override void Feed()
        {
            base.Feed();
        }

        /// <summary>
        /// Prompts cleaning of cage
        /// </summary>
        public override void CleanCage()
        {
            base.CleanCage();
        }

        public void Squeez()
        {
            Console.WriteLine("squeez");
        }
    }
}
