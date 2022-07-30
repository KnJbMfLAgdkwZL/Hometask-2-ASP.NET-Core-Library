using Business.Dto.In;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIWeb.Controllers;

[ApiController]
[Produces("application/json")]
public class RatingController : Controller
{
    private readonly IRatingService _ratingService;
    private readonly IBookService _bookService;

    public RatingController(IRatingService ratingService, IBookService bookService)
    {
        _ratingService = ratingService;
        _bookService = bookService;
    }

    [HttpPost]
    [Route("api/books/{bookId:int}/rate")]
    public async Task<IActionResult> Save(CancellationToken token, [FromRoute] int bookId,
        [FromBody] RatingDtoIn ratingDtoIn)
    {
        if (ModelState.IsValid)
        {
            if (!await _bookService.IsExist(bookId, token))
            {
                return BadRequest("Wrong bookId");
            }

            ratingDtoIn.BookId = bookId;
            var id = await _ratingService.RateAsync(ratingDtoIn, token);
            return Ok(new {id});
        }

        return BadRequest();
    }
}