using Business.Interfaces;
using DataAccess.Interfaces;
using Database.Models;

namespace Business.Services;

public class ReviewService : IReviewService
{
    private readonly IGeneralRepository<Review> _reviewRepository;

    public ReviewService(IGeneralRepository<Review> reviewRepository)
    {
        _reviewRepository = reviewRepository;
    }

    /*
    ### 6. Save a review for the book.
    PUT https://{{baseUrl}}/api/books/{id}/review

    {
	    "message": "string",
	    "reviewer": "string",
    }

    # Response
    # {
    # 	"id": "number"
    # }
    */
    public async Task<Review> SaveAsync(Review reviewDto, CancellationToken token)
    {
        var review = await _reviewRepository.AddAsync(reviewDto, token);
        return review;
    }
}