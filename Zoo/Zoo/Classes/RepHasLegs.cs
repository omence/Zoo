using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class RepHasLegs : Reptile
    {
        public bool Crawls { get; set; }

        abstract public void Climb();
    }
}
