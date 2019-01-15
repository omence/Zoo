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
        virtual public void Roar()
        {
            Console.WriteLine("Roar");
        }
    }
}
