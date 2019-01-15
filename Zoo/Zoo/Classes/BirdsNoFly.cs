using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class BirdsNoFly : Birds
    {
        public bool RunsFast { get; set; } = true;

        /// <summary>
        /// Makes animal run
        /// </summary>
        abstract public string Run();
    }
}
