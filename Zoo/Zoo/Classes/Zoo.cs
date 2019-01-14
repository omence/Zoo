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


        public void OpeningProcess()
        {
            Console.WriteLine("Open the Zoo");
        }

        public void ClosingProcess()
        {
            Console.WriteLine("Open the Zoo");
        }
      

    }

   
}
