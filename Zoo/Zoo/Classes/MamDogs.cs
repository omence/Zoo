using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class MamDogs : Mamal
    {
       virtual public bool PacAnimal { get; set; }


        /// <summary>
        /// Dog howls
        /// </summary>
        virtual public void Howl()
        {
            Console.WriteLine("Howl");
        }
    }
}
