using Business.Dto.In;
using Database.Models;

namespace Business.Interfaces;

public interface IReviewService
{
    Task<int> SaveAsync(ReviewDtoIn reviewDtoIn, CancellationToken token);
    Task DeleteAsync(int bookId, CancellationToken token);
}