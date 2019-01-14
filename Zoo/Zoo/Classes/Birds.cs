using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Birds : Zoo
    {
        public bool HasFeather { get; set; }

        public bool LaysEggs { get; set; }

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
