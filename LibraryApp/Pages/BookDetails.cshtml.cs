using LibraryApp.Data;
using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Pages;

public class BookDetails : PageModel
{
    private readonly LibraryContext _context;

    public Book? Book { get; set; }

    public BookDetails(LibraryContext context)
    {
        _context = context;
    }

    public async Task OnGet(int id)
    {
        Book = await _context.Books.FirstOrDefaultAsync(b => b.Id == id);
    }
}