using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class RepNoLegs : Reptile
    {
        abstract public bool Slithers { get; set; }

        virtual public void Hisses()
        {
            Console.WriteLine("hisss");
        }
    }
}
