using AutoMapper;
using Business.Dto.In;
using Business.Interfaces;
using DataAccess.Interfaces;
using Database.Models;

namespace Business.Services;

public class RatingService : IRatingService
{
    private readonly IGeneralRepository<Rating> _ratingRepository;
    private readonly IMapper _mapper;

    public RatingService(IGeneralRepository<Rating> ratingRepository, IMapper mapper)
    {
        _ratingRepository = ratingRepository;
        _mapper = mapper;
    }

    public async Task<int> RateAsync(RatingDtoIn ratingDtoIn, CancellationToken token)
    {
        var ratingModel = _mapper.Map<RatingDtoIn, Rating>(ratingDtoIn);
        var rating = await _ratingRepository.AddAsync(ratingModel, token);
        return rating.Id;
    }

    public async Task DeleteAsync(int bookId, CancellationToken token)
    {
        await _ratingRepository.RemoveRangeAsync(rating => rating.BookId == bookId, token);
    }
}