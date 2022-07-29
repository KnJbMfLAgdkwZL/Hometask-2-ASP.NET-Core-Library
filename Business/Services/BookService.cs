using System.Linq.Expressions;
using Business.Interfaces;
using DataAccess.Interfaces;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Business.Services;

public class BookService : IBookService
{
    private readonly IGeneralRepository<Book> _bookRepository;

    public BookService(IGeneralRepository<Book> bookRepository)
    {
        _bookRepository = bookRepository;
    }

    /*### 1. Get all books. Order by provided value (title or author)
        GET https://{{baseUrl}}/api/books?order=author
    # Response
    # [{
    # 	"id": "number",    
    # 	"title": "string",
    # 	"author": "string",
    # 	"rating": "decimal",          	average rating
    # 	"reviewsNumber": "decimal"    	count of reviews
    # }]
    */
    //public async Task<PageResult<User>>
    public async Task<List<Book>> GetAllAsync(string order, CancellationToken token)
    {
        Expression<Func<Book, bool>> condition = (book) => book.Id > 0;

        var includes = new List<Expression<Func<Book, object>>>()
        {
            book => book.Ratings ?? new List<Rating>()
        };

        Expression<Func<Book, object>> orderBy = order.ToLower() switch
        {
            "title" => (book) => book.Title,
            "author" => (book) => book.Author,
            _ => (book) => book.Id
        };

        var books = await _bookRepository.GetAllIncludeManyAsync(condition, includes, orderBy, token);
        // get average rating for book
        return books;
    }

    /*
    ### 2. Get top 10 books with high rating and number of reviews greater than 10. 
    You can filter books by specifying genre. Order by rating
    GET https://{{baseUrl}}/api/recommended?genre=horror
    # Response
    # [{
    # 	"id": "number",
    # 	"title": "string",
    # 	"author": "string",
    # 	"rating": "decimal",          	average rating
    # 	"reviewsNumber": "decimal"    	count of reviews
    # }]
     */
    public async Task<List<Book>> GetTop10Async(string genre, CancellationToken token)
    {
        Expression<Func<Book, bool>> condition = (book) => EF.Functions.Like(book.Genre, $"%{genre}%");

        var includes = new List<Expression<Func<Book, object>>>()
        {
            book => book.Ratings ?? new List<Rating>()
        };

        Expression<Func<Book, object>> orderBy = (book) => book.Ratings.Average(rating => rating.Score);

        var books = await _bookRepository.GetAllIncludeManyAsync(condition, includes, orderBy, token);
        // get average rating for book
        return books.Take(10).ToList();
    }

    /*    
    ### 3. Get book details with the list of reviews
        GET https://{{baseUrl}}/api/books/{id}
    # Response
    # {
    # 	"id": "number",
    # 	"title": "string",
    # 	"author": "string",
    # 	"cover": "string",
    # 	"content": "string",
    # 	"rating": "decimal",          	average rating
    # 	"reviews": [{
    #     	    "id": "number",
    #     	    "message": "string",
    #     	    "reviewer": "string",
    # 	}]
    # }}
    */
    public async Task<Book?> GetOneAsync(int id, CancellationToken token)
    {
        var includes = new List<Expression<Func<Book, object>>>()
        {
            book => book.Ratings ?? new List<Rating>(),
            book => book.Reviews
        };

        var book = await _bookRepository.GetOneIncludeManyAsync(book => book.Id == id, includes, token);
        // get average rating for book
        return book;
    }


    /*
    ### 4. Delete a book using a secret key. Save the secret key in the config of your application. Compare this key with query param
    DELETE https://{{baseUrl}}/api/books/{id}?secret=qwerty
    */
    public async Task DeleteOneAsync(int id, string secret, CancellationToken token)
    {
        if (secret == "qwerty")
        {
            await _bookRepository.RemoveIfExistAsync(book => book.Id == id, token);
        }
    }


    /*
    ### 5. Save a new book.
    POST https://{{baseUrl}}/api/books/save
    {
        "id": "number",             	// if id is not provided create a new book, otherwise - update an existing one
        "title": "string",
        "cover": "string",          	// save image as base64
        "content": "string",
        "genre": "string",
        "author": "string"
    }
    # Response
    # {
    # 	"id": "number"
    # }
    */
    public async Task<Book> SaveAsync(Book bookDto, CancellationToken token)
    {
        var bookModel = await _bookRepository.AddOrUpdateAsync(book => book.Id == bookDto.Id, bookDto, token);

        return bookModel;
    }
}