using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BickingTrip;

public class Trip
{
    private string destination;
    private double distance;
    private double rating;

    public Trip(string destination, double distance, double rating)
    {
        this.Destination = destination;
        this.Distance = distance;
        this.Rating = rating;
    }

    public string Destination
    {
        get { return this.destination; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                this.destination = value;
            else
                throw new Exception("this.destination cannot be null or empty.");
        }
    }

    public double Distance
    {
        get { return this.distance; }
        set
        {
            if (value >= 0)
                this.distance = value;
            else
                this.distance = 0;
        }
    }

    public double Rating
    {
        get { return this.rating; }
        set
        {
            if (value >= 0 && value <= 5)
                this.rating = value;
            else if (value > 5)
                this.rating = 5;
            else if (value < 0)
                this.rating = 0;
        }
    }
    public override string ToString()
    {
        return $"Destination: {this.Destination} | Distance: {this.Distance} | Rating: {this.Rating}";
    }
}
