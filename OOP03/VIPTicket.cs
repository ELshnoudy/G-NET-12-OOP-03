using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess;
        public decimal ServiceFee;
        public VIPTicket(string movieName, double price, bool loungeAccess)
        : base(movieName, price + 50)
        {
            LoungeAccess = loungeAccess;
        }

        public override string ToString()
        {
            return base.ToString() + $", Lounge Access: {LoungeAccess}, Service Fee: {ServiceFee}";
        }
    }
}
