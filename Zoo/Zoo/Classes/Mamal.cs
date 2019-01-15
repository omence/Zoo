using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Mamal : Animal
    {
        public bool HasHair { get; set; } = true;

        public bool LiveBirth { get; set; } = true;


        /// <summary>
        /// How grooming happends
        /// </summary>
        virtual public void GroomsSelf()
        {
            Console.WriteLine("Grooming Self");

            
        }

        /// <summary>
        /// How grooming happends
        /// </summary>
        virtual public void GroomsOthers()
        {
            Console.WriteLine("Grooming Others");


        }

    }
}
