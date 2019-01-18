using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Snake : RepNoLegs
    {
        public override bool Slithers { get; set; } = true;

        public override bool NeedsOxy { get; set; } = true;

        public bool HasScales { get; set; } = true;

        /// <summary>
        /// Makes hiss
        /// </summary>
        public override string Hisses()
        {
            Console.WriteLine("hisss");

            return "hisss";
        }

        /// <summary>
        /// Makes squeez
        /// </summary>
        public void Squeez()
        {
            Console.WriteLine("squeez");
        }
    }
}
