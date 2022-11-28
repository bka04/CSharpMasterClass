using System;
namespace CSharpMasterClass
{
    public class Ticket : IEquatable<Ticket>
    {
        public int DurationInHours { get; set; }
        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }

        // return true if same time in hours rather than the same object reference
        public bool Equals(Ticket other)
        {
            return (this.DurationInHours == other.DurationInHours);
        }
    }
}

