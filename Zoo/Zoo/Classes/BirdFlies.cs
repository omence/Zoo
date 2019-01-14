using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class BirdFlies : Birds
    {
        public bool FlapsWings { get; set; }

        abstract public void Fly();
    }
}
