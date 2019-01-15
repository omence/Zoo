using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class ReplegsLizard : RepHasLegs, ICanAlsoFly
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

        public string ICanFly()
        {
            Console.WriteLine("I'm flying!");

            return "I'm flying!";
        }

    }
}
