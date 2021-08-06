using Xunit;

namespace BootcampFunctions.Test {
    public class CheckWeekDayTest {
        [Fact]
        public void ShouldReturnTrueIfItsWeekDay() {
            Assert.True(CheckWeekDay.IsWeekDay("Monday"));
            Assert.False(CheckWeekDay.IsWeekDay("Sunday"));
            Assert.True(CheckWeekDay.IsWeekDay("monday"));
        }
    }
}