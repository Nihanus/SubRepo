namespace App.Models;

public class BookReservation{
    public int Id {get; set;}
    public string? BookName {get; set;}
    public DateTime StartDay {get; set;}
    public DateTime EndDay {get; set;}
    public bool QuickPickUp {get; set;}
}