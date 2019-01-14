using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Mamal : Zoo
    {
        public override int MaxVisitors { get => throw new NotImplementedException(); set => throw new NotImplementedException();}

        public override int NumOfCages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool HasHair { get; set; }

        public bool LiveBirth { get; set; }


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
            Console.WriteLine("Clean the Cages");
        }

        public override void OpeningProcess()
        {
            Console.WriteLine("Open the zoo");
        }

        public override void ClosingProcess()
        {
            Console.WriteLine("close the zoo");
        }
    }
}
