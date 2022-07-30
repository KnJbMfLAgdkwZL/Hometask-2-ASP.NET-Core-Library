using Business.Dto.In;
using Business.Dto.Out;

namespace Business.Interfaces;

public interface IBookService
{
    Task<List<BookShortDtoOut>> GetAllAsync(string order, CancellationToken token);
    Task<List<BookShortDtoOut>> GetTop10Async(string genre, CancellationToken token);
    Task<BookDetailDtoOut?> GetOneAsync(int id, CancellationToken token);
    Task DeleteOneAsync(int id, CancellationToken token);
    Task<int> SaveAsync(BookDtoIn bookDtoIn, CancellationToken token);
    Task<bool> IsExist(int id, CancellationToken token);
}