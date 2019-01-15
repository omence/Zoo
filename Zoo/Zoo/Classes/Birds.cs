using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Birds : Animal
    {

        public bool HasFeather { get; set; } = true;

        public bool LaysEggs { get; set; } = true;

        /// <summary>
        /// abstract method forces cleaning style of bird
        /// </summary>
        abstract public string CleanFeathers();
        


    }
}
