using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Zoo
    {
        public int MaxVisitors { get; set; }

        public int NumOfCages { get; set; }

        virtual public bool OpenToPublic { get; set; }

        /// <summary>
        /// sends open zoo to console
        /// </summary>
        public void OpeningProcess()
        {
            Console.WriteLine("Open the Zoo");
        }

        /// <summary>
        /// sends close zoo to console
        /// </summary>
        public void ClosingProcess()
        {
            Console.WriteLine("Close the Zoo");
        }
      

    }

   
}
