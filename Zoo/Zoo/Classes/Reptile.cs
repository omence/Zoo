using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Reptile : Zoo
    {
        public bool LaysEggs { get; set; }

        public bool ColdBloded { get; set; }


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
