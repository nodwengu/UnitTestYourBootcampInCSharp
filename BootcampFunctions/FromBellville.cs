using System;

namespace BootcampFunctions {
    public class FromBellville {
        public static bool IsFromBellville(string regNumber) {
            return regNumber.ToUpper().StartsWith("CY");
        }

    }
}