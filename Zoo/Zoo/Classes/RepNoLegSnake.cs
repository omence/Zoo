using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class RepNoLegSnake : RepNoLegs
    {
        public override bool Slithers { get; set; } = true;

        public bool HasScales { get; set; } = true;

        public override string Hisses()
        {
            Console.WriteLine("hisss");

            return "hisss";
        }

        public void Squeez()
        {
            Console.WriteLine("squeez");
        }
    }
}
