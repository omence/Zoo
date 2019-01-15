using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class MamCatLion : MamCats
    {
        public bool HasMane { get; set; } = true;

        /// <summary>
        /// Makes lion roar
        /// </summary>
        public override void Roar()
        {
            base.Roar();
        }
    }
}
