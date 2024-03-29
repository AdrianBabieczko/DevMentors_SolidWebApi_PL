using MySpot.Api.Exceptions;

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

    public void AddReservation(Reservation reservation, DateTime now)
    {
        var isInvalidDate = reservation.Date.Date < From ||
                            reservation.Date.Date > To ||
                            reservation.Date.Date < now;
        
        if (isInvalidDate)
        {
            throw new InvalidReservationDateException(reservation.Date);
        }

        var reservationAlreadyExists = Reservations.Any(x =>
            x.Date.Date == reservation.Date.Date);

        if (reservationAlreadyExists)
        {
            throw new ParkingSpotAlreadyReservedException(Name, reservation.Date);
        }

        _reservations.Add(reservation);
    }

    public void RemoveReservation(Guid reservationId) =>
        _reservations.Remove(_reservations.FirstOrDefault(x => x.Id == reservationId));
}