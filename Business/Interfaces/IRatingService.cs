using Business.Dto.In;

namespace Business.Interfaces;

public interface IRatingService
{
    Task<int> RateAsync(RatingDtoIn ratingDtoIn, CancellationToken token);
    Task DeleteAsync(int bookId, CancellationToken token);
}