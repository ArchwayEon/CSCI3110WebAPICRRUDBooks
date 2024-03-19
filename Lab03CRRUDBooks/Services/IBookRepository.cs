using Lab03CRRUDBooks.Models.Entities;

namespace Lab03CRRUDBooks.Services;

public interface IBookRepository
{
    Task<ICollection<Book>> ReadAllAsync();
    Task<Book> CreateAsync(Book newBook);
    Task<Book?> ReadAsync(int id);
    Task UpdateAsync(int oldId, Book book);
    Task DeleteAsync(int id);
}

