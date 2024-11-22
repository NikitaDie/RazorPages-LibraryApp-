using LibraryApp.Data;
using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Pages;

public class BooksModel : PageModel
{
    private readonly LibraryContext _context;
    public List<Book> Books { get; set; }
    
    public BooksModel(LibraryContext context)
    {
        _context = context;
    }
    
    public async Task OnGet()
    {
        Books = await _context.Books.ToListAsync();
    }
}