using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    public class Ticket
    {
        private string movieName;
        private double price;

        public static int ticketCounter = 0;
        public int ticketID { get; }
        public Ticket(string moviname, double price)
        {
            this.movieName = moviname;
            this.price = price;
            ++ticketCounter;
            this.ticketID = ticketCounter;
        }


        public string MovieName
        {
            get { return movieName; }
            set
            {
                if (value != null || value != "")
                {
                    movieName = value;
                }
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }

        public double PriceAfterTax
        {
            get { return price * 1.14; }
        }
        public override string ToString()
        {
            return $"ticket id : {ticketID} | Movie Name: {movieName} | Price: {price} | Price after tax: {PriceAfterTax}";
        }

        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
        }

    }
}
