using System;

namespace PaymentDateCheck
{
    public class Bill
    {
        private readonly IHolidayService _holidayservice;

        public Bill(IHolidayService service)
        {
            _holidayservice = service;
        }

        public Double PayBill(Double paymentDue)
        {
            return paymentDue;
        }
    }

}

