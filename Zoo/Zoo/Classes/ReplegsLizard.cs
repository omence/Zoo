using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class ReplegsLizard : RepHasLegs, ICanAlsoFly
    {
        public bool ChangesColor { get; set; } = true;

        /// <summary>
        /// Makes turn green
        /// </summary>
        public void TurnGreen()
        {
            Console.WriteLine("Lizard turns green");
        }

        /// <summary>
        /// Makes climb
        /// </summary>
        public override void Climb()
        {
            base.Climb();
        }

        /// <summary>
        /// Makes fly
        /// </summary>
        public string ICanFly()
        {
            Console.WriteLine("I'm flying!");

            return "I'm flying!";
        }

    }
}
