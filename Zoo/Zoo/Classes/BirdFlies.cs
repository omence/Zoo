using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class BirdFlies : Birds
    {
        public bool FlapsWings { get; set; } = true;


        /// <summary>
        /// how bird flies
        /// </summary>
        abstract public string Fly();
    }
}
