namespace MySpot.Api.Entities;

public class WeeklyParkingSpot
{
    private readonly HashSet<Reservation> _reservations = new();

    public Guid Id { get;}
    public DateTime From { get; }
    public DateTime To { get;}
    public string Name { get; }
    public IEnumerable<Reservation> Reservations => _reservations;

    public WeeklyParkingSpot(Guid id, DateTime from, DateTime to, string name)
    {
        Id = id;
        From = from;
        To = to;
        Name = name;
    }

    public void AddReservation(Reservation reservation)
    {
        var now = DateTime.UtcNow.Date;
        
        if (!(reservation.Date.Date >= now && reservation.Date.Date <= now.AddDays(remainingDays)))
        {
            return default;
        }
    }
}