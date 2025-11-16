//Thread Synchronization using lock()--Real life exp...

using System;
using System.Threading;

class HelloWorld {
    
  static void Main() {
      BookMyShow bookMyShow = new BookMyShow();
      
      Thread t1 = new Thread(bookMyShow.TicketBooking)
      {
          Name="Thread1"
      };
      
      Thread t2 = new Thread(bookMyShow.TicketBooking)
      {
          Name="Thread2"
      };
      
      Thread t3 = new Thread(bookMyShow.TicketBooking)
      {
          Name = "Thread3"
      };
      
      t1.Start();
      t2.Start();
      t3.Start();
  }
}
public class BookMyShow
{
    int AvailableTickets = 3;
    static int i = 1,j=2,k=3;
    
    private object lockObject = new object();
    
    public void BookTicket(string name,int noOfTicket)
    {
        lock(lockObject)
        {
            if(noOfTicket <= AvailableTickets)
            {
                Console.WriteLine(noOfTicket+" tickets booked by "+name);
                AvailableTickets = AvailableTickets - noOfTicket;
            }
            else
            {
                Console.WriteLine("Tickets not available");
            }
        }
    }
    
    public void TicketBooking()
    {
        string name = Thread.CurrentThread.Name;
        if(name.Equals("Thread1"))
        {
            BookTicket(name,i);
        }
        else if(name.Equals("Thread2"))
        {
            BookTicket(name,j);
        }
        else
        {
            BookTicket(name,k);
        }
    }
}