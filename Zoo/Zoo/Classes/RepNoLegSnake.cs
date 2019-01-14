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
            Console.WriteLine("Feed Snake");
        }

        /// <summary>
        /// Prompts cleaning of cage
        /// </summary>
        public override void CleanCage()
        {
            Console.WriteLine("Feed Snake");
        }

        public void Squeez()
        {
            Console.WriteLine("squeez");
        }
    }
}
