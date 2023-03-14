namespace MySpot.Api.DTO;

public class ReservationDto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string EmployeeName { get; set; }
    public string LicensePlate { get; set; }
    public DateTime Date { get; set; }
    public Guid ParkingSpotId { get; set; }
}