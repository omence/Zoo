using System;
using Zoo.Classes;

namespace Zoo
{
    public class Program
    {
        /// <summary>
        /// calls methods
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the Zoo");
            Console.WriteLine();
            MakeLizard();
            MakeSnake();
            MakeEagle();
            MakeFlamingo();
            MakeWolf();
            MakeLion();
            Console.ReadLine();
        }

        /// <summary>
        /// Creates an instance of Lizard
        /// </summary>
        public static void MakeLizard()
        {
            Lizard replegsLizard = new Lizard();
            Console.WriteLine("Lizard");
            replegsLizard.Breathing();
            replegsLizard.HeartBeats();
            replegsLizard.Eating();
            replegsLizard.LayEggs();
            replegsLizard.Climb();
            replegsLizard.TurnGreen();
            replegsLizard.ICanFly();
        }

        /// <summary>
        /// Creates an instance of Snake
        /// </summary>
        public static void MakeSnake()
        {
            Snake repNoLegSnake = new Snake();
            Console.WriteLine();
            Console.WriteLine("Snake");
            repNoLegSnake.Breathing();
            repNoLegSnake.HeartBeats();
            repNoLegSnake.Eating();
            repNoLegSnake.LayEggs();
            repNoLegSnake.Hisses();
            repNoLegSnake.Squeez();
        }

        /// <summary>
        /// Creates an instance of Eagle
        /// </summary>
        public static void MakeEagle()
        {
            Eagle birdsFliesEagle = new Eagle();
            Console.WriteLine();
            Console.WriteLine("Eagle");
            birdsFliesEagle.Breathing();
            birdsFliesEagle.HeartBeats();
            birdsFliesEagle.Eating();
            birdsFliesEagle.CleanFeathers();
            birdsFliesEagle.Fly();
        }

        /// <summary>
        /// Creates an instance of Flamingo
        /// </summary>
        public static void MakeFlamingo()
        {
            Flamingo birdsNoFlyFlamingo = new Flamingo();
            Console.WriteLine();
            Console.WriteLine("Flamingo");
            birdsNoFlyFlamingo.Breathing();
            birdsNoFlyFlamingo.HeartBeats();
            birdsNoFlyFlamingo.Eating();
            birdsNoFlyFlamingo.CleanFeathers();
            birdsNoFlyFlamingo.Run();
            birdsNoFlyFlamingo.StandsOnOneLeg();
            birdsNoFlyFlamingo.ICanSwim();
            birdsNoFlyFlamingo.ICanFly();
        }

        /// <summary>
        /// Creates an instance of Wolf
        /// </summary>
        public static void MakeWolf()
        {
            Wolf mamDogWolf = new Wolf();
            Console.WriteLine();
            Console.WriteLine("Wolf");
            mamDogWolf.Breathing();
            mamDogWolf.HeartBeats();
            mamDogWolf.Eating();
            mamDogWolf.GroomsOthers();
            mamDogWolf.Howl();
            mamDogWolf.ICanSwim();
        }

        /// <summary>
        /// Creates an instance of Lion
        /// </summary>
        public static void MakeLion()
        {
            Lion mamCatLion = new Lion();
            Console.WriteLine();
            Console.WriteLine("Lion");
            mamCatLion.Breathing();
            mamCatLion.HeartBeats();
            mamCatLion.Eating();
            mamCatLion.Roar();
        }
    }
}
