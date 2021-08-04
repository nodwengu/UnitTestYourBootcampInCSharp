using System;
using Xunit;
using BootcampFunctions;

namespace BootcampFunctions.Test
{
    public class TotalPhoneBillTest
    {
        [Fact]
        public void ShouldBeAbleToGreetJo()
        {   
            Assert.Equal($"R{2.75}", TotalPhoneBill.CalcTotalPhoneBill("call"));    
            Assert.Equal($"R{0.65}", TotalPhoneBill.CalcTotalPhoneBill("sms"));      
            Assert.Equal($"R{7.45}", TotalPhoneBill.CalcTotalPhoneBill("call, sms, call, sms, sms"));
        }

    }
}