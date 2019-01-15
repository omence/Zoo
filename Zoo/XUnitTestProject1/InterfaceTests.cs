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
            MamDogWolf mamDogWolf = new MamDogWolf();

            //Act
            string swim = mamDogWolf.ICanSwim();

            //Assert
            Assert.Equal("I'm swimming!", swim);
        }

        [Fact]
        public void FlamingoSwimWorks()
        {
            //Arrange
            BirdsNoFlyFlamingo birdsNoFlyFlamingo = new BirdsNoFlyFlamingo();

            //Act
            string swim = birdsNoFlyFlamingo.ICanSwim();

            //Assert
            Assert.Equal("I'm swimming!", swim);
        }

        [Fact]
        public void FlamingoFlyWorks()
        {
            //Arrange
            BirdsNoFlyFlamingo birdsNoFlyFlamingo = new BirdsNoFlyFlamingo();

            //Act
            string fly = birdsNoFlyFlamingo.ICanSwim();

            //Assert
            Assert.Equal("I'm swimming!", fly);
        }
    }
}
