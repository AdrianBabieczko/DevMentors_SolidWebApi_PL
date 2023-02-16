namespace MySpot.Api.Models;

public class Reservation
{
    public string EmployeeName { get; set; }
    public string ParkingSpotName { get; set; }
    public string LicensePlate { get; set; } //Nr rejestracyjny
    public DateTime Date { get; set; }
}