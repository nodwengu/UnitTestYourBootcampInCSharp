using System;

namespace BootcampFunctions {
   public class RegistrationCheck {
      public static bool RegCheck(string regNumber, string location) {
         return regNumber.ToUpper().EndsWith(location);
      }
   }
}