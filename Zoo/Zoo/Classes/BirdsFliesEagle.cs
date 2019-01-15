using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class BirdsFliesEagle : BirdFlies
    {
        public string WingSpan { get; set; } = "Has 6ft wing span";


        public override string Fly()
        {
            Console.WriteLine("The Eagle glides");

            return "The Eagle glides";
        }

        public override string CleanFeathers()
        {
            Console.WriteLine("Cleans feathers by bathing");

            return "Cleans feathers by bathing";
        }
    }
}
