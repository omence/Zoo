using System;
using Xunit;
using Zoo;
using Zoo.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void LizarsBreathingWorks()
        {
            //Arrange
            Lizard replegsLizard = new Lizard();

            //Act
            string breath = replegsLizard.Breathing();

            //Assert
            Assert.Equal("Breathing", breath);
        }

        [Fact]
        public void LizarsClimbsWorks()
        {
            //Arrange
            Lizard replegsLizard = new Lizard();

            //Act
            string eggs = replegsLizard.LayEggs();

            //Assert
            Assert.Equal("Laying Eggs", eggs);
        }

        [Fact]
        public void SnakeEatingWorks()
        {
            //Arrange
            Snake repNoLegSnake = new Snake();

            //Act
            string eats = repNoLegSnake.Eating();

            //Assert
            Assert.Equal("Eating", eats);
        }

        [Fact]
        public void SnakeHissesWorks()
        {
            //Arrange
            Snake repNoLegSnake = new Snake();

            //Act
            string hiss = repNoLegSnake.Hisses();

            //Assert
            Assert.Equal("hisss", hiss);
        }

        [Fact]
        public void EagleBreathingWorks()
        {
            //Arrange
            Eagle birdsFliesEagle = new Eagle();

            //Act
            string breath = birdsFliesEagle.Breathing();

            //Assert
            Assert.Equal("Breathing", breath);
        }

        [Fact]
        public void EagleFlyWorks()
        {
            //Arrange
            Eagle birdsFliesEagle = new Eagle();

            //Act
            string fly = birdsFliesEagle.Fly();

            //Assert
            Assert.Equal("The Eagle glides", fly);
        }

        [Fact]
        public void FlamingoEatingWorks()
        {
            //Arrange
            Flamingo birdsNoFlyFlamingo = new Flamingo();

            //Act
            string eat = birdsNoFlyFlamingo.Eating();

            //Assert
            Assert.Equal("Eating", eat);
        }

        [Fact]
        public void FlamingoRunWorks()
        {
            //Arrange
            Flamingo birdsNoFlyFlamingo = new Flamingo();

            //Act
            string run = birdsNoFlyFlamingo.Run();

            //Assert
            Assert.Equal("Flamingo is running", run);
        }

        [Fact]
        public void WolfHowlWorks()
        {
            //Arrange
            Wolf mamDogWolf = new Wolf();

            //Act
            string howl = mamDogWolf.Howl();

            //Assert
            Assert.Equal("Howl", howl);
        }

        [Fact]
        public void WolfEatWorks()
        {
            //Arrange
            Wolf mamDogWolf = new Wolf();

            //Act
            string eat = mamDogWolf.Eating();

            //Assert
            Assert.Equal("Eating", eat);
        }

        [Fact]
        public void LionRoarWorks()
        {
            //Arrange
            Lion mamCatLion = new Lion();

            //Act
            string roar = mamCatLion.Roar();

            //Assert
            Assert.Equal("Roar", roar);
        }

        [Fact]
        public void LionEatWorks()
        {
            //Arrange
            Lion mamCatLion = new Lion();

            //Act
            string eat = mamCatLion.Eating();

            //Assert
            Assert.Equal("Eating", eat);
        }


    }
}
