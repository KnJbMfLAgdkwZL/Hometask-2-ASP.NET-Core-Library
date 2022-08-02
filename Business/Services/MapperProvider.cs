using AutoMapper;
using Business.Dto.In;
using Business.Dto.Out;
using Business.Interfaces;
using Database.Models;

namespace Business.Services;

public class MapperProvider : IMapperProvider
{
    private readonly IMapper _mapper;
    public IMapper GetMapper() => _mapper;

    public MapperProvider()
    {
        _mapper = Initialize();
    }

    private IMapper Initialize()
    {
        var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Book, BookShortDtoOut>(MemberList.None)
                    .ForMember(des => des.Id, m => m.MapFrom(sou => sou.Id))
                    .ForMember(des => des.Title, m => m.MapFrom(sou => sou.Title))
                    .ForMember(des => des.Author, m => m.MapFrom(sou => sou.Author))
                    .ForMember(des => des.Rating,
                        m => m.MapFrom(sou => (sou.Ratings.Count > 0) ? sou.Ratings.Average(r => r.Score) : 0))
                    .ForMember(des => des.ReviewsNumber,
                        m => m.MapFrom(sou => (sou.Reviews.Count > 0) ? sou.Reviews.Count : 0))
                    .ForMember(des => des.Cover, m => m.MapFrom(sou => sou.Cover));

                cfg.CreateMap<Review, BookReviewsDtoOut>(MemberList.None)
                    .ForMember(des => des.Id, m => m.MapFrom(sou => sou.Id))
                    .ForMember(des => des.Message, m => m.MapFrom(sou => sou.Message))
                    .ForMember(des => des.Reviewer, m => m.MapFrom(sou => sou.Reviewer));

                cfg.CreateMap<Book, BookDetailDtoOut>(MemberList.None)
                    .ForMember(des => des.Id, m => m.MapFrom(sou => sou.Id))
                    .ForMember(des => des.Title, m => m.MapFrom(sou => sou.Title))
                    .ForMember(des => des.Author, m => m.MapFrom(sou => sou.Author))
                    .ForMember(des => des.Cover, m => m.MapFrom(sou => sou.Cover))
                    .ForMember(des => des.Content, m => m.MapFrom(sou => sou.Content))
                    .ForMember(des => des.Rating,
                        m => m.MapFrom(sou => (sou.Ratings.Count > 0) ? sou.Ratings.Average(r => r.Score) : 0))
                    .ForMember(des => des.Reviews, m => m.MapFrom(sou => sou.Reviews));

                cfg.CreateMap<RatingDtoIn, Rating>(MemberList.None)
                    .ForMember(des => des.BookId, m => m.MapFrom(sou => sou.BookId))
                    .ForMember(des => des.Score, m => m.MapFrom(sou => sou.Score));

                cfg.CreateMap<ReviewDtoIn, Review>(MemberList.None)
                    .ForMember(des => des.BookId, m => m.MapFrom(sou => sou.BookId))
                    .ForMember(des => des.Message, m => m.MapFrom(sou => sou.Message))
                    .ForMember(des => des.Reviewer, m => m.MapFrom(sou => sou.Reviewer));

                cfg.CreateMap<BookDtoIn, Book>(MemberList.None)
                    .ForMember(des => des.Id, m => m.MapFrom(sou => sou.Id))
                    .ForMember(des => des.Title, m => m.MapFrom(sou => sou.Title))
                    .ForMember(des => des.Cover, m => m.MapFrom(sou => sou.Cover))
                    .ForMember(des => des.Content, m => m.MapFrom(sou => sou.Content))
                    .ForMember(des => des.Genre, m => m.MapFrom(sou => sou.Genre))
                    .ForMember(des => des.Author, m => m.MapFrom(sou => sou.Author));
            }
        );
        config.AssertConfigurationIsValid();
        return config.CreateMapper();
    }
}