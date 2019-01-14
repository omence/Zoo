using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class ReplegsLizard : RepHasLegs
    {
        public bool ChangesColor { get; set; }

        /// <summary>
        /// Prompts feeding of the lizard
        /// </summary>
        public override void Feed()
        {
            Console.WriteLine("Feed the lizard");
        }

        /// <summary>
        /// prompts cleaning of the cage
        /// </summary>
        public override void CleanCage()
        {
            Console.WriteLine("Clean the Lizard's cage");
        }

        /// <summary>
        /// action lizard climbs
        /// </summary>
        public override void Climb()
        {
            Console.WriteLine("Lizard Climbs Branch");
        }

        public void TurnGreen()
        {
            Console.WriteLine("Lizard turns green");
        }

    }
}
