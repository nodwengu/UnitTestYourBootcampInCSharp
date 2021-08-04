using System;
using Xunit;
using BootcampFunctions;

namespace BootcampFunctions.Test
{
    public class TotalPhoneBillTest
    {
        [Fact]
        public void ShouldBeAbleToGetCallCost()
        {
            TotalPhoneBill bill1 = new TotalPhoneBill();
            Assert.Equal($"R{2.75}", bill1.CalcTotalPhoneBill("call"));

            TotalPhoneBill bill2 = new TotalPhoneBill();
            Assert.Equal($"R{0.65}", bill2.CalcTotalPhoneBill("sms"));

            TotalPhoneBill bill3 = new TotalPhoneBill();
           Assert.Equal($"R{7.45}", bill3.CalcTotalPhoneBill("call,sms,call,sms,sms"));
            
        }

        [Fact]
        public void ShouldBeAbleGetSmsCost()
        {
            TotalPhoneBill bill2 = new TotalPhoneBill();
            Assert.Equal($"R{0.65}", bill2.CalcTotalPhoneBill("sms"));
        }

        [Fact]
        public void ShouldBeAbleToGetTotalCost()
        {
            TotalPhoneBill bill3 = new TotalPhoneBill();
           Assert.Equal($"R{7.45}", bill3.CalcTotalPhoneBill("call,sms,call,sms,sms"));
        }

    }
}