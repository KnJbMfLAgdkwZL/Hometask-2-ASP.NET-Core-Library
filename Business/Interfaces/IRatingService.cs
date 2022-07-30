using Business.Dto.In;

namespace Business.Interfaces;

public interface IRatingService
{
    Task RateAsync(RatingDtoIn ratingDtoIn, CancellationToken token);
}