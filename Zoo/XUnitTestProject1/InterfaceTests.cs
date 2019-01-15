using System;
using Xunit;
using Zoo.Interfaces;
using Zoo.Classes;

namespace XUnitTestProject1
{
    public class InterfaceTests
    {
        [Fact]
        public void WolfSwimWorks()
        {
            //Arrange
            Wolf mamDogWolf = new Wolf();

            //Act
            string swim = mamDogWolf.ICanSwim();

            //Assert
            Assert.Equal("I'm swimming!", swim);
        }

        [Fact]
        public void FlamingoSwimWorks()
        {
            //Arrange
            Flamingo birdsNoFlyFlamingo = new Flamingo();

            //Act
            string swim = birdsNoFlyFlamingo.ICanSwim();

            //Assert
            Assert.Equal("I'm swimming!", swim);
        }

        [Fact]
        public void FlamingoFlyWorks()
        {
            //Arrange
            Flamingo birdsNoFlyFlamingo = new Flamingo();

            //Act
            string fly = birdsNoFlyFlamingo.ICanFly();

            //Assert
            Assert.Equal("I'm Flying", fly);
        }

        [Fact]
        public void LizardFlyWorks()
        {
            //Arrange
            Lizard replegsLizard = new Lizard();

            //Act
            string fly = replegsLizard.ICanFly();

            //Assert
            Assert.Equal("I'm flying!", fly);
        }
    }
}
