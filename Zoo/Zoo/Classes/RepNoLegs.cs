using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class RepNoLegs : Reptile
    {
        abstract public bool Slithers { get; set; }

        /// <summary>
        /// Makes hiss
        /// </summary>
        abstract public string Hisses();
    }
}
