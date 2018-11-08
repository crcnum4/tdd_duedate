using NUnit.Framework;
using PaymentDateCheck;
using System;
using System.Collections.Generic;

namespace Tests
{    
    [TestFixture]
    public class BillShould
    {
        [Test]
        public void ifBussinessDay_ReturnDueDate()
        {
            var input = new DateTime(2018,8,6);
            var mockHolidayService = new HolidayService<IHolidayService>();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            var expected = input;
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void ifSaturday_ReturnMonday()
        {
            
        }
        [Test]
        public void ifSunday_ReturnMonday()
        {
            
        }
        [Test]
        public void ifHoliday_ReturnNonHoliday()
        {
            
        }
        [Test]
        public void ifHoliday_ReturnWeekday()
        {
            
        }
    }
}