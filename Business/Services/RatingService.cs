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

    /*### 7. Rate a book
    PUT https://{{baseUrl}}/api/books/{id}/rate
    {
        "score": "number",    	// score can be from 1 to 5
    }    */
    public async Task RateAsync(RatingDtoIn ratingDtoIn, CancellationToken token)
    {
        var rating = _mapper.Map<RatingDtoIn, Rating>(ratingDtoIn);
        await _ratingRepository.AddAsync(rating, token);
    }
}