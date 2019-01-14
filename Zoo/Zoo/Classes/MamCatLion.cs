using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class MamCatLion : MamCats
    {
        public bool HasMane { get; set; }

        public override bool PacAnimal { get => base.PacAnimal; set => base.PacAnimal = value; }

        public override void Feed()
        {
            Console.WriteLine("Feed the Lion");
        }

        public override void CleanCage()
        {
            Console.WriteLine("Feed the Lion");
        }

        public override void Roar()
        {
            base.Roar();
        }
    }
}
