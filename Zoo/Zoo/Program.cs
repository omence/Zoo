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
            ReplegsLizard replegsLizard = new ReplegsLizard();
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
            RepNoLegSnake repNoLegSnake = new RepNoLegSnake();
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
            BirdsFliesEagle birdsFliesEagle = new BirdsFliesEagle();
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
            BirdsNoFlyFlamingo birdsNoFlyFlamingo = new BirdsNoFlyFlamingo();
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
            MamDogWolf mamDogWolf = new MamDogWolf();
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
            MamCatLion mamCatLion = new MamCatLion();
            Console.WriteLine();
            Console.WriteLine("Lion");
            mamCatLion.Breathing();
            mamCatLion.HeartBeats();
            mamCatLion.Eating();
            mamCatLion.Roar();
        }
    }
}
