using Business.Dto.In;
using Database.Models;

namespace Business.Interfaces;

public interface IReviewService
{
    Task<Review> SaveAsync(ReviewDtoIn reviewDtoIn, CancellationToken token);
}