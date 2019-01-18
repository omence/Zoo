using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Lion : MamCats
    {
        public bool HasMane { get; set; } = true;

        public override bool NeedsOxy { get; set; } = true;



    }
}
