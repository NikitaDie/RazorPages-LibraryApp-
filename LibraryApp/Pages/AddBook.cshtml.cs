using LibraryApp.Data;
using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryApp.Pages;

public class AddBook : PageModel
{
    private readonly LibraryContext _context;

    public AddBook(LibraryContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Book NewBook { get; set; }
    
    public void OnGet() { }
    
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        
        _context.Books.Add(NewBook);
        await _context.SaveChangesAsync();
        
        return RedirectToPage("/books");
    }
}