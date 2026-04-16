using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    public class Cinema
    {
        private Ticket[] tickets = new Ticket[20];
        public string CinemaName { get; set; }

        private Projector projector = new Projector();

        public Cinema(string name)
        {
            CinemaName = name;
        }
        public Ticket this[int Index]
        {
            get
            {
                if (Index < tickets.Length && Index >= 0)
                {
                    return tickets[Index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (Index < tickets.Length && Index >= 0)
                {
                    tickets[Index] = value;
                }
            }
        }


        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }
            return false;
        }
        public void PrintAllTickets()
        {
            Console.WriteLine("----------- All Tickets --------------");

            foreach (var t in tickets)
            {
                if (t != null)
                    Console.WriteLine(t);
            }
        }

        public void OpenCinema()
        {
            Console.WriteLine($"----------------- {CinemaName} opened -----------------");
            projector.Start();
        }

        public void CloseCinema()
        {
            Console.WriteLine($"----------------- {CinemaName} closed -----------------");
            projector.Stop();
        }
    }
}
