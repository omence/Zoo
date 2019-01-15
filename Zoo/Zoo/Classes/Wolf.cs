using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Wolf : MamDogs, ISwim
    {
        public bool HuntsInPack { get; set; } = true;

        /// <summary>
        /// makes wolf swim
        /// </summary>
        public string ICanSwim()
        {
            Console.WriteLine("I'm swimming!");

            return "I'm swimming!";
        }
    }
    
    

}
