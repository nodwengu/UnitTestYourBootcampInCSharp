using Xunit;


namespace BootcampFunctions.Test {
    public class CountRegitrationsTest {
        [Fact]
        public void ShouldCountAllRegNumber() {
            CountRegitrations counter = new CountRegitrations();
            Assert.Equal(3, counter.CountRegNumber("CA 182736,CY 523519,CJ 812328"));
            Assert.Equal(1, counter.CountRegNumber("CA 182736"));
        } 

        [Fact]
        public void ShouldReturnZeroIfNoRegNumberAdded() {
            CountRegitrations counter = new CountRegitrations();
            Assert.Equal(0, counter.CountRegNumber(""));
        } 
    }
}