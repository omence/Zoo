using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Mamal : Zoo
    {
        public bool HasHair { get; set; }

        public bool LiveBirth { get; set; }


        /// <summary>
        /// abstract method forces feeding
        /// </summary>
        abstract public void Feed();


        /// <summary>
        /// abstract method forces feeding
        /// </summary>
        abstract public void CleanCage();
    }
}
