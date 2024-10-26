namespace App.Services;

using App.Helpers;
using App.Models;

public interface IBookReserve{
    List<BookReservation> GetBookReservations();
    List<BookType> GetBookTypes();
    void ReserveBook(BookReservation model);
}

public class BookReserve : IBookReserve{
    private BookContext _context;
    public BookReserve(BookContext context){
        _context = context;
    }

    private double GetPriceOfStay(BookReservation model){
        double price = 0;
        var type = model.Type;

        string tempDate = DateTime.Now.ToString("yyyy/MM/dd");
        DateTime currentDate = DateTime.Parse(tempDate);

        if(model.StartDay.CompareTo(model.EndDay) > 0){
            throw new AppException("Day of book return can't be before day of pickup");
        }
        else if(model.StartDay.CompareTo(model.EndDay) == 0){
            throw new AppException("Day of return can't be the same day as day of pickup");
        }
        else if(model.StartDay.CompareTo(currentDate) == 0 && !model.QuickPickUp){
            throw new AppException("Can't pick up the book today if you didn't choose \"Quick pick up\"");
        }

        TimeSpan duration = model.EndDay.Subtract(model.StartDay);
        if(type.Name == "Book"){
            price = 2*duration.Days;
        }
        else if(type.Name == "Audiobook"){
            price = 3*duration.Days;
        }

        if(duration.Days > 10){
            price *= 0.8;
        }
        else if(duration.Days > 3){
            price *= 0.9;
        }

        price += 3;
        if(model.QuickPickUp){
            price += 5;
        }

        return price;
    }
    public void ReserveBook(BookReservation model){
        double price = GetPriceOfStay(model);
        model.PriceOfStay = price;
        _context.Reservations.Add(model);
    }

    public List<BookReservation> GetBookReservations(){
        return _context.Reservations.ToList();
    }
    public List<BookType> GetBookTypes(){
        return _context.Types.ToList();
    }
}