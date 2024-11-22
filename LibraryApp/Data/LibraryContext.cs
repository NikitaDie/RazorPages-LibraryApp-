using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Data;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Book> Books { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Book>().HasData(
            new Book
            {
                Id = 1,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Genre = "Fiction",
                Publisher = "Scribner",
                Year = 1925
            },
            new Book
            {
                Id = 2,
                Title = "1984",
                Author = "George Orwell",
                Genre = "Dystopian",
                Publisher = "Secker & Warburg",
                Year = 1949
            },
            new Book
            {
                Id = 3,
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                Genre = "Fiction",
                Publisher = "J.B. Lippincott & Co.",
                Year = 1960
            },
            new Book
            {
                Id = 4,
                Title = "Moby-Dick",
                Author = "Herman Melville",
                Genre = "Adventure",
                Publisher = "Harper & Brothers",
                Year = 1851
            }
        );
    }
}