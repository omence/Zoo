using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Zoo
    {
        abstract public int MaxVisitors { get; set; }

        abstract public int NumOfCages { get; set; }

        virtual public bool OpenToPublic { get; set; }

        /// <summary>
        /// sends open zoo to console
        /// </summary>
        abstract public void OpeningProcess();
     

        /// <summary>
        /// sends close zoo to console
        /// </summary>
        abstract public void ClosingProcess();
        
      

    }

   
}
