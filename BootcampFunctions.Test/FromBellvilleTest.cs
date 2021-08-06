using System;
using Xunit;
using BootcampFunctions;

namespace BootcampFunctions.Test {
    public class FromBellvilleTest {
        [Fact]
        public void ShouldReturnTrueIfNumberIsForBellville() {
            Assert.True(FromBellville.IsFromBellville("CY 123"));
        }

        [Fact]
        public void ShouldReturnFalseIfNumberIsNotForBellville() {
            Assert.False(FromBellville.IsFromBellville("CJ 123"));
        }

        [Fact]
        public void ShouldReturnTrueIfNumberIsAllLowercase() {
            Assert.True(FromBellville.IsFromBellville("cy 123"));
        }

        [Fact]
        public void ShouldReturnTrueIfNumberIsMixedCase() {
            Assert.True(FromBellville.IsFromBellville("Cy 123"));
        }
    }
    
}
