using Lab03CRRUDBooks.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab03CRRUDBooks.Services;

public class ApplicationDbContext(DbContextOptions options) 
    : DbContext(options)
{
    public DbSet<Book> Books => Set<Book>();
}
