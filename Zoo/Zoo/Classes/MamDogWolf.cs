using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class MamDogWolf : MamDogs
    {
        public bool HuntsInPack { get; set; }

        public override bool PacAnimal { get => base.PacAnimal; set => base.PacAnimal = value; }


        /// <summary>
        /// promps feeding
        /// </summary>
        public override void Feed()
        {
            base.Feed();
        }

        /// <summary>
        /// prompts cleaning
        /// </summary>
        public override void CleanCage()
        {
            base.CleanCage();
        }

        /// <summary>
        /// makes wolf howl
        /// </summary>
        public override void Howl()
        {
            base.Howl();
        }
    }
}
