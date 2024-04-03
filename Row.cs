using System.Collections.Generic;
using System.Linq;

// Name: Akarsh Pradipkumar Patel
// Email ID: patelt29@mymacewan.ca
// ID: 3154218
public class Row
{
    public List<Seat> Seats { get; }

    public Row(int rowNumber)
    {
        Seats = new List<Seat>
        {
            new Seat(rowNumber, SeatLabel.A),
            new Seat(rowNumber, SeatLabel.B),
            new Seat(rowNumber, SeatLabel.C),
            new Seat(rowNumber, SeatLabel.D)
        };
    }

    public override string ToString()
    {
        string rowString = "";
        foreach (var seat in Seats)
        {
            if (seat.IsBooked)
            {
                rowString += $"{seat.Passenger.GetInitials()} ";
            }
            else
            {
                rowString += $"{seat.Label} ";
            }
        }
        return rowString.Trim();
    }
}
