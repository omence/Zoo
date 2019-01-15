using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Animal
    {
        public bool IsAlive { get; set; } = true;

        public bool NeedsOxy { get; set; } = true;

        public bool Eats { get; set; } = true;

        /// <summary>
        /// Animals hearts beat
        /// </summary>
        public void HeartBeats()
        {
            Console.WriteLine("Heart Beating");
        }
     

        /// <summary>
        /// animals breath
        /// </summary>
        public string Breathing()
        {
            Console.WriteLine("Breathing");

            return "Breathing";
        }

        public string Eating()
        {
            Console.WriteLine("Eating");

            return "Eating";
        }



    }

   
}
