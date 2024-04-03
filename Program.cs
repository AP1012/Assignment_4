using System;

class Program
{
    static void Main(string[] args)
    {
        // Display user information
        Console.WriteLine("Name: Akarsh Pradipkumar Patel");
        Console.WriteLine("ID: 3154218");
        Console.WriteLine("Email ID: patela87@mymacewan.ca");
        Console.WriteLine();

        // Start the Ticketing application
        TicketingApp ticketingApp = new TicketingApp();
        ticketingApp.Run();
    }
}
