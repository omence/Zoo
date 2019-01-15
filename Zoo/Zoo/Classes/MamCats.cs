using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class MamCats : Mamal
    {
        virtual public bool PacAnimal { get; set; } = false;

        /// <summary>
        /// Cat roars
        /// </summary>
        virtual public string Roar()
        {
            Console.WriteLine("Roar");

            return "Roar";
        }
    }
}
