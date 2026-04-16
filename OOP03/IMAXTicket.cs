using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movieName, double price, bool is3D)
            : base(movieName, is3D ? price + 30 : price)
        {
            Is3D = is3D;
        }

        public override string ToString()
        {
            return base.ToString() + $", 3D: {Is3D}";
        }
    }
}
