namespace App.Services;

using App.Models;

public class BookReserve{
    private BookContext _context;
    public BookReserve(BookContext context){
        _context = context;
    }
}