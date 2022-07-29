using Database.Models;

namespace Business.Interfaces;

public interface IReviewService
{
    Task<Review> SaveAsync(Review reviewDto, CancellationToken token);
}