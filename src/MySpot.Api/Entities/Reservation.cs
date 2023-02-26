namespace MySpot.Api.Entities;

public class Reservation
{
    public int Id { get; set; }
    public string EmployeeName { get; set; }
    public string ParkingSpotName { get; set; }
    public string LicensePlate { get; set; } //Nr rejestracyjny
    public DateTime Date { get; set; }
}