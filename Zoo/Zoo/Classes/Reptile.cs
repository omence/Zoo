using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Reptile : Animal
    {
        public bool LaysEggs { get; set; } = true;

        public bool ColdBloded { get; set; } = true;


        /// <summary>
        /// Reptiles lay eggs
        /// </summary>
        virtual public string LayEggs()
        {
            Console.WriteLine("Laying Eggs");

            return "Laying Eggs";
        }

    }

    


   

}
