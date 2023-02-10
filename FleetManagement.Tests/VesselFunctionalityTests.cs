using DotNet6Console.Models;
using System;
using Xunit;

namespace FleetManagement.Tests
{
    public class VesselFunctionalityTests
    {

       
      
        [Fact]
        public void ValidName_YearBuilt_Should_Be_Set_Correctly()
        {
            // Arrange
            string expectedName = "Test Vessel";
            uint expectedYearBuilt = 2020;

            Ferry ferry = new Ferry(expectedName,expectedYearBuilt, 6,new Speed(20));

            // Act
            string actualName = ferry.Name;
            uint actualYearBuilt = ferry.YearBuilt;

            // Assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedYearBuilt, actualYearBuilt);

        }

        [Fact]
        public void NonValidName_Should_Throw_Exception()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Ferry("", "2020", 6, new Speed(20)));

        }

        [Fact]
        public void NonValidFormat_YearBuilt_Should_Throw_Exception()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new Tugboat("Test Tugboat", "A2020A", 6, new Speed(20)));
        }

        [Fact]
        public void Null_YearBuilt_Should_Throw_Exception()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new Tugboat("Test Tugboat", "", 6, new Speed(20)));
        }

        [Fact]
        public void OldShipException_Should_Be_Thrown_For_Vessels_Older_Than_20_Years()
        {
            // Arrange & Act & Assert
            Assert.Throws<OldShipException>(() => new Submarine("Test Tugboat", "2000", 6, new Speed(20)));
        }


        [Fact]
        public void Ferry_Passengers_Should_Be_Set_Correctly()
        {
            // Arrange

            int expectedPassengers = 6;

            Ferry ferry = new Ferry("Test Ferry", 2015, expectedPassengers, new Speed(1.5));

            // Act
            int actualPassengers = ferry.passengers;
            
            // Assert
            Assert.Equal(expectedPassengers, actualPassengers);
            
        }
    }
}