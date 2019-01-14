using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Reptile : Zoo
    {
        public override int MaxVisitors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int NumOfCages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool LaysEggs { get; set; }

        public bool ColdBloded { get; set; }

        public override void OpeningProcess()
        {
            Console.WriteLine("Open the zoo");
        }

        public override void ClosingProcess()
        {
            Console.WriteLine("Close the zoo");
        }
        /// <summary>
        /// abstract method forces feeding
        /// </summary>
        virtual public void Feed()
        {
            Console.WriteLine("Feeding Time");
        }


        /// <summary>
        /// abstract method forces feeding
        /// </summary>
        virtual public void CleanCage()
        {
            Console.WriteLine("Clean Cages");
        }


    }

    


   

}
