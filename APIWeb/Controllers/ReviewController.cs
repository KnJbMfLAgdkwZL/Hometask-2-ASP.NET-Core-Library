using Business.Dto.In;
using Business.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace APIWeb.Controllers;

[EnableCors("AllowAll")]
[ApiController]
[Produces("application/json")]
public class ReviewController : Controller
{
    private readonly IReviewService _reviewService;
    private readonly IBookService _bookService;

    public ReviewController(IReviewService reviewService, IBookService bookService)
    {
        _reviewService = reviewService;
        _bookService = bookService;
    }

    [HttpPost]
    [Route("api/books/{bookId:int}/review")]
    public async Task<IActionResult> Save(CancellationToken token, [FromRoute] int bookId,
        [FromBody] ReviewDtoIn reviewDtoIn)
    {
        if (ModelState.IsValid)
        {
            if (!await _bookService.IsExist(bookId, token))
            {
                return BadRequest("Wrong bookId");
            }

            reviewDtoIn.BookId = bookId;
            var id = await _reviewService.SaveAsync(reviewDtoIn, token);
            return Ok(new {id});
        }

        return BadRequest();
    }
}