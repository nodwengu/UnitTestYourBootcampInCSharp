
namespace BootcampFunctions {
    public class CountRegitrations {
        public int CountRegNumber(string numbers) {
            if(numbers == "") {
                return 0;
            }

            return numbers.Split(",").Length;
        }
    }
}