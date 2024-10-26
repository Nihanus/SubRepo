using System.ComponentModel.DataAnnotations;

namespace App.Models;

public class BookReservation{
    public int Id {get; set;}
    public string? BookName {get; set;}
    public DateTime StartDay {get; set;}
    public DateTime EndDay {get; set;}
    public bool QuickPickUp {get; set;}
    public double PriceOfStay {get; set;} = 0;
    public BookType? TypeofBook {get; set;}
}

public class BookType{
    public int Id {get; set;}
    public string? Name {get; set;}
}