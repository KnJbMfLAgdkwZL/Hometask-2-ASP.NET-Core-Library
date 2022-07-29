using Business.Interfaces;
using DataAccess.Interfaces;
using Database.Models;

namespace Business.Services;

public class RatingService : IRatingService
{
    private readonly IGeneralRepository<Rating> _ratingRepository;

    public RatingService(IGeneralRepository<Rating> ratingRepository)
    {
        _ratingRepository = ratingRepository;
    }

    /*    
    ### 7. Rate a book
    PUT https://{{baseUrl}}/api/books/{id}/rate
    {
        "score": "number",    	// score can be from 1 to 5
    }
    */
    public async Task RateAsync(int bookId, byte score, CancellationToken token)
    {
        var rate = new Rating()
        {
            Score = score,
            BookId = bookId
        };
        await _ratingRepository.AddAsync(rate, token);
    }
}