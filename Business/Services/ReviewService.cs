using AutoMapper;
using Business.Dto.In;
using Business.Interfaces;
using DataAccess.Interfaces;
using Database.Models;

namespace Business.Services;

public class ReviewService : IReviewService
{
    private readonly IGeneralRepository<Review> _reviewRepository;
    private readonly IMapper _mapper;

    public ReviewService(IGeneralRepository<Review> reviewRepository, IMapper mapper)
    {
        _reviewRepository = reviewRepository;
        _mapper = mapper;
    }

    /*### 6. Save a review for the book.
    PUT https://{{baseUrl}}/api/books/{id}/review

    {
	    "message": "string",
	    "reviewer": "string",
    }
    # Response
    # {
    # 	"id": "number"
    # }    */
    public async Task<Review> SaveAsync(ReviewDtoIn reviewDtoIn, CancellationToken token)
    {
        var review = _mapper.Map<ReviewDtoIn, Review>(reviewDtoIn);
        return await _reviewRepository.AddAsync(review, token);
        ;
    }
}