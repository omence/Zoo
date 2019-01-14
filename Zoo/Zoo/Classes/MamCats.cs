using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class MamCats : Mamal
    {
        virtual public bool PacAnimal { get; set; }

        /// <summary>
        /// Cat roars
        /// </summary>
        virtual public void Roar()
        {
            Console.WriteLine("Roar");
        }
    }
}
