using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class MamDogWolf : MamDogs
    {
        public bool HuntsInPack { get; set; }

        public override bool PacAnimal { get => base.PacAnimal; set => base.PacAnimal = value; }

        public override void Feed()
        {
            Console.WriteLine("feed the wolf");
        }

        public override void CleanCage()
        {
            Console.WriteLine("Clean the wolf's cage");
        }

        public override void Howl()
        {
            base.Howl();
        }
    }
}
