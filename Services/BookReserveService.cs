namespace App.Services;

using App.Models;

public interface IBookReserve{
    void ReserveBook(BookReservation model);
}

public class BookReserve : IBookReserve{
    private BookContext _context;
    public BookReserve(BookContext context){
        _context = context;
    }

    private decimal GetPriceOfStay(BookReservation model){
        return 0;
    }
    public void ReserveBook(BookReservation model){
        decimal price = GetPriceOfStay(model);
        model.PriceOfStay = price;
        _context.Reservations.Add(model);
    }
}