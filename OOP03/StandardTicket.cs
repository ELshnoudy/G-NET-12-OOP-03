using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal class StandardTicket : Ticket
    {
        public string seatNumber;
        public StandardTicket(string moviname, double price, string seatNumber) : base(moviname, price)
        {
            this.seatNumber = seatNumber;
        }

        public override string ToString()
        {
            return base.ToString() + $", Seat: {seatNumber}";
        }
    }
}
