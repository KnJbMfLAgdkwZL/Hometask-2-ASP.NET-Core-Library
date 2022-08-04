using System.Linq.Expressions;
using AutoMapper;
using Business.Dto.In;
using Business.Dto.Out;
using Business.Interfaces;
using DataAccess.Interfaces;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Business.Services;

public class BookService : IBookService
{
    private readonly IGeneralRepository<Book> _bookRepository;
    private readonly IMapper _mapper;
    private readonly IRatingService _ratingService;
    private readonly IReviewService _reviewService;


    public BookService(
        IGeneralRepository<Book> bookRepository,
        IMapper mapper, IRatingService ratingService,
        IReviewService reviewService)
    {
        _bookRepository = bookRepository;
        _mapper = mapper;
        _ratingService = ratingService;
        _reviewService = reviewService;
    }

    public async Task<List<BookShortDtoOut>> GetAllAsync(string order, CancellationToken token)
    {
        Expression<Func<Book, bool>> condition = (book) => book.Id > 0;

        var includes = new List<Expression<Func<Book, object>>>()
        {
            book => book.Ratings,
            book => book.Reviews
        };

        Expression<Func<Book, object>> orderBy = order.ToLower() switch
        {
            "title" => (book) => book.Title,
            "author" => (book) => book.Author,
            _ => (book) => book.Id
        };

        var books = await _bookRepository.GetAllIncludeManyAsync(condition, includes, orderBy, token);

        return _mapper.Map<List<Book>, List<BookShortDtoOut>>(books);
    }

    public async Task<List<BookShortDtoOut>> GetTop10Async(string genre, CancellationToken token)
    {
        Expression<Func<Book, bool>> condition = (book) =>
            EF.Functions.Like(book.Genre, $"%{genre}%") && book.Ratings.Count > 0;

        var includes = new List<Expression<Func<Book, object>>>()
        {
            book => book.Ratings,
            book => book.Reviews
        };

        Expression<Func<Book, object>> orderBy = (book) => book.Ratings.Average(rating => rating.Score);

        var books = await _bookRepository.GetAllIncludeManyAsync(condition, includes, orderBy, token);

        return _mapper.Map<List<Book>, List<BookShortDtoOut>>(books.Take(10).ToList());
    }

    public async Task<BookDetailDtoOut?> GetOneAsync(int id, CancellationToken token)
    {
        var includes = new List<Expression<Func<Book, object>>>()
        {
            book => book.Ratings,
            book => book.Reviews
        };

        var book = await _bookRepository.GetOneIncludeManyAsync(book => book.Id == id, includes, token);

        return book != null ? _mapper.Map<Book, BookDetailDtoOut>(book) : null;
    }

    public async Task DeleteOneAsync(int id, CancellationToken token)
    {
        await _bookRepository.RemoveIfExistAsync(book => book.Id == id, token);
        await _ratingService.DeleteAsync(id, token);
        await _reviewService.DeleteAsync(id, token);
    }

    public async Task<int> SaveAsync(BookDtoIn bookDtoIn, CancellationToken token)
    {
        var bookModel = _mapper.Map<BookDtoIn, Book>(bookDtoIn);
        var book = await _bookRepository.AddOrUpdateAsync(book => book.Id == bookModel.Id, bookModel, token);
        return book.Id;
    }

    public async Task<bool> IsExist(int id, CancellationToken token)
    {
        var book = await _bookRepository.GetOneAsync(book => book.Id == id, token);
        return book != null;
    }
}