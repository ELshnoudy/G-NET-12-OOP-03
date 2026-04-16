using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;

namespace OOP03
{
    public enum typeOFTicket
    {
        Standard = 1,
        VIP,
        IMAX
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions
            #region Q1
            //Q1: Identify the type of relationship in each scenario below(Inheritance,
            //Association, Aggregation, Composition, or Dependency):

            //a) A University has Departments. If the university is closed, the departments no longer exist.
            // this is composition 
            //b) A Driver uses a Car.The driver does not own the car.
            // this is association 
            //c) A Dog is an Animal.
            // this is inheritance 
            //d) A Team has Players. If the team is deleted, the players still exist.
            // this is aggregation
            //e) A method receives a Logger as a parameter and calls it inside the method only.
            // this is dependency
            #endregion

            #region Q2 
            //Q2: Answer the following questions about access modifiers and sealed:

            //a) A parent class has a protected field.Can a child class in a different assembly access it?
            //What about through an object instance from outside?
            // 1- yes he can access it because inheritance allow the child can access protected members
            // 2- no he can't access because protected can't accessable through object instance from outside

            //b) What is the difference between protected internal and private protected?
            // protected internal: accessible in the same assembly or from child classes in any assembly.
            // private protected: accessible in the same assembly and only from child classes.

            //c) What does the sealed keyword do when applied to a class? What about when applied to a method?
            // when applied to a class: it blocked other classes from inheriting from it.
            // when applied to a method: it blocked child classes from overriding the method.

            //d) Can you create an object from a sealed class using new? Why or why not?
            // yes because sealing class only blocked inheritance.


            #endregion

            #endregion

            #region Part 02 : Practical (Extending the Movie Ticket Booking System)

            Cinema cinema = new Cinema("dokki Cinema");
            cinema.OpenCinema();

            Ticket t1 = new StandardTicket("Batman", 100, "A5");
            Ticket t2 = new VIPTicket("Avengers", 150, true);
            Ticket t3 = new IMAXTicket("Interstellar", 120, true);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAllTickets();
            Console.WriteLine("---------------------------");

            Console.WriteLine("Total Tickets: " + Ticket.GetTotalTicketsSold());

            Console.WriteLine($"booking ref : {BookingHelper.GenerateBookingReference()}");
            Console.WriteLine($"booking ref : {BookingHelper.GenerateBookingReference()}");
            Console.WriteLine($"group discount : {BookingHelper.CalcGroupDiscount(5, 100)}");

            cinema.CloseCinema();


            #endregion
        }
    }
}
