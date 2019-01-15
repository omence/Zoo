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
        /// abstract method forces feeding
        /// </summary>
        virtual public void GroomsSelf()
        {
            Console.WriteLine("Grooming Self");

            
        }

        virtual public void GroomsOthers()
        {
            Console.WriteLine("Grooming Others");


        }

    }
}
