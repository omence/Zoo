using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class ReplegsLizard : RepHasLegs
    {
        public bool ChangesColor { get; set; } = true;


        public void TurnGreen()
        {
            Console.WriteLine("Lizard turns green");
        }

        public override void Climb()
        {
            base.Climb();
        }

    }
}
