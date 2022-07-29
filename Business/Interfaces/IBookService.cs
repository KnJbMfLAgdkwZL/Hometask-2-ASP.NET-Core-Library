using Database.Models;

namespace Business.Interfaces;

public interface IBookService
{
    Task<List<Book>> GetAllAsync(string order, CancellationToken token);
    Task<List<Book>> GetTop10Async(string genre, CancellationToken token);
    Task<Book?> GetOneAsync(int id, CancellationToken token);
    Task DeleteOneAsync(int id, string secret, CancellationToken token);
    Task<Book> SaveAsync(Book bookDto, CancellationToken token);
}