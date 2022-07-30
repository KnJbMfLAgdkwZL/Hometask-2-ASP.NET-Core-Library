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

    public async Task<int> SaveAsync(ReviewDtoIn reviewDtoIn, CancellationToken token)
    {
        var reviewModel = _mapper.Map<ReviewDtoIn, Review>(reviewDtoIn);
        var review = await _reviewRepository.AddAsync(reviewModel, token);
        return review.Id;
    }

    public async Task DeleteAsync(int bookId, CancellationToken token)
    {
        await _reviewRepository.RemoveRangeAsync(rating => rating.BookId == bookId, token);
    }
}