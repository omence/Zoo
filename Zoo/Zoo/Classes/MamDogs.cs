using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class MamDogs : Mamal
    {
        virtual public bool PacAnimal { get; set; } = true;


        /// <summary>
        /// Dog howls
        /// </summary>
        virtual public string Howl()
        {
            Console.WriteLine("Howl");

            return "Howl";
        }
    }
}
