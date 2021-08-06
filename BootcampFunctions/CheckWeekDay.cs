using System.Linq;

namespace BootcampFunctions {
    public class CheckWeekDay {
        public static bool IsWeekDay(string day) {
            string[] weekDaysList = { "Monday", "Tuesady", "Wednesday", "Thursday", "Friday" };
            string theDay = char.ToUpper(day[0]) + day.Substring(1);
            return weekDaysList.Contains(theDay);
        }
    }
}