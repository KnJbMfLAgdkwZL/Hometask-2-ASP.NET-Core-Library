using Business.Dto.In;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIWeb.Controllers;

[ApiController]
[Produces("application/json")]
[Route("api")]
public class BookController : Controller
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    [Route("books")]
    public async Task<IActionResult> GetBooks(CancellationToken token, [FromQuery] string? order = "")
    {
        order ??= "";
        return Ok(await _bookService.GetAllAsync(order, token));
    }

    [HttpGet]
    [Route("recommended")]
    public async Task<IActionResult> GetTop10(CancellationToken token, [FromQuery] string? genre = "")
    {
        genre ??= "";
        return Ok(await _bookService.GetTop10Async(genre, token));
    }

    [HttpGet]
    [Route("books/{id:int}")]
    public async Task<IActionResult> GetBookDetails(CancellationToken token, [FromRoute] int id)
    {
        var book = await _bookService.GetOneAsync((int) id, token);
        if (book != null)
        {
            return Ok(book);
        }

        return NoContent();
    }

    [HttpDelete]
    [Route("books/{id:int}")]
    public async Task<IActionResult> Delete(CancellationToken token, [FromRoute] int id, [FromQuery] string secret)
    {
        if (secret != "qwerty")
        {
            return Unauthorized();
        }

        await _bookService.DeleteOneAsync(id, token);
        return Ok();
    }

    [HttpPost]
    [Route("books/save")]
    public async Task<IActionResult> Save(CancellationToken token, [FromBody] BookDtoIn bookDtoIn)
    {
        var id = await _bookService.SaveAsync(bookDtoIn, token);
        return Ok(new {id});
    }
}