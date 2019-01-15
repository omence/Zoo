using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class RepHasLegs : Reptile
    {
        public bool Crawls { get; set; } = true;

        virtual public void Climb()
        {
            Console.WriteLine("Climbs a branch");
        }

        
    }
}
