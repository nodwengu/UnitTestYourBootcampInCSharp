using System;

namespace BootcampFunctions
{
    public class TotalPhoneBill
    {
         public string CalcTotalPhoneBill(string callsAndSms)
        {
            var callsAndSmsArr = callsAndSms.Split(",");

            double callsTotal = 0.0;
            double smsTotal = 0.0;


            foreach (var item in callsAndSmsArr) {
               if (item == "call") {
                  callsTotal += 2.75;
               }
               else {
                  smsTotal += 0.65;
               }
            }
            // Console.WriteLine("callsTotal " + callsTotal);
            // Console.WriteLine("smsTotal " + smsTotal);
            return $"R{callsTotal + smsTotal}";
        }
    }
}