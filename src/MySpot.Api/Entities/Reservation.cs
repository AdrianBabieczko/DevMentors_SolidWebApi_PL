namespace MySpot.Api.Entities;

public class Reservation
{
    public int Id { get;}
    public string EmployeeName { get; private set; }
    public string LicensePlate { get; private set; } //Nr rejestracyjny
    public DateTime Date { get; private set; }

    public Reservation(int id, string employeeName, string licensePlate, DateTime date)
    {
        Id = id;
        EmployeeName = employeeName;
        LicensePlate = licensePlate;
        Date = date;
    }
}