using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class BirdsNoFly : Birds
    {
        public bool RunsFast { get; set; }

        abstract public void Run();
    }
}
