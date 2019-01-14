using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class MamCatLion : MamCats
    {
        public bool HasMane { get; set; }

        public override bool PacAnimal { get => base.PacAnimal; set => base.PacAnimal = value; }

        /// <summary>
        /// Prompts feeding
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
        /// Makes lion roar
        /// </summary>
        public override void Roar()
        {
            base.Roar();
        }
    }
}
