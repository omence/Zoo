using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Birds : Zoo
    {

        public override int MaxVisitors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int NumOfCages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool HasFeather { get; set; }

        public bool LaysEggs { get; set; }

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

        public override void OpeningProcess()
        {
            Console.WriteLine("Open Zoo");
        }

        public override void ClosingProcess()
        {
            Console.WriteLine("Close Zoo");
        }


    }
}
