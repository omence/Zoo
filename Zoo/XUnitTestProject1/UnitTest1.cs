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
            ReplegsLizard replegsLizard = new ReplegsLizard();

            //Act
            string breath = replegsLizard.Breathing();

            //Assert
            Assert.Equal("Breathing", breath);
        }

        [Fact]
        public void LizarsClimbsWorks()
        {
            //Arrange
            ReplegsLizard replegsLizard = new ReplegsLizard();

            //Act
            string eggs = replegsLizard.LayEggs();

            //Assert
            Assert.Equal("Laying Eggs", eggs);
        }

        [Fact]
        public void SnakeEatingWorks()
        {
            //Arrange
            RepNoLegSnake repNoLegSnake = new RepNoLegSnake();

            //Act
            string eats = repNoLegSnake.Eating();

            //Assert
            Assert.Equal("Eating", eats);
        }

        [Fact]
        public void SnakeHissesWorks()
        {
            //Arrange
            RepNoLegSnake repNoLegSnake = new RepNoLegSnake();

            //Act
            string hiss = repNoLegSnake.Hisses();

            //Assert
            Assert.Equal("hisss", hiss);
        }

        [Fact]
        public void EagleBreathingWorks()
        {
            //Arrange
            BirdsFliesEagle birdsFliesEagle = new BirdsFliesEagle();

            //Act
            string breath = birdsFliesEagle.Breathing();

            //Assert
            Assert.Equal("Breathing", breath);
        }

        [Fact]
        public void EagleFlyWorks()
        {
            //Arrange
            BirdsFliesEagle birdsFliesEagle = new BirdsFliesEagle();

            //Act
            string fly = birdsFliesEagle.Fly();

            //Assert
            Assert.Equal("The Eagle glides", fly);
        }

        [Fact]
        public void FlamingoEatingWorks()
        {
            //Arrange
            BirdsNoFlyFlamingo birdsNoFlyFlamingo = new BirdsNoFlyFlamingo();

            //Act
            string eat = birdsNoFlyFlamingo.Eating();

            //Assert
            Assert.Equal("Eating", eat);
        }

        [Fact]
        public void FlamingoRunWorks()
        {
            //Arrange
            BirdsNoFlyFlamingo birdsNoFlyFlamingo = new BirdsNoFlyFlamingo();

            //Act
            string run = birdsNoFlyFlamingo.Run();

            //Assert
            Assert.Equal("Flamingo is running", run);
        }
    }
}
