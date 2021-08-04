using System;

namespace BootcampFunctions
{
    public class TotalPhoneBill
    {
        public static string CalcTotalPhoneBill(string callsAndSms)
        {
            var callsAndSmsArr = callsAndSms.Split(", ");

            var callsTotal = 0.0;
            var smsTotal = 0.0;

            foreach (var item in callsAndSmsArr) {
               if (item == "call") {
                  callsTotal += 2.75;
               }
               else {
                  smsTotal += 0.65;
               }
            }
            return $"R{callsTotal + smsTotal}";
        }
    }
}