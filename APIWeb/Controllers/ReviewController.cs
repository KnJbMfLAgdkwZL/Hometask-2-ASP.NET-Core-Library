using Business.Dto.In;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIWeb.Controllers;

[ApiController]
[Produces("application/json")]
public class ReviewController : Controller
{
    private readonly IReviewService _reviewService;

    public ReviewController(IReviewService reviewService)
    {
        _reviewService = reviewService;
    }

    [HttpPost]
    [Route("api/books/{bookId:int}/review")]
    public async Task<IActionResult> Save(CancellationToken token, [FromRoute] int bookId,
        [FromBody] ReviewDtoIn reviewDtoIn)
    {
        if (ModelState.IsValid)
        {
            reviewDtoIn.BookId = bookId;
            var id = await _reviewService.SaveAsync(reviewDtoIn, token);
            return Ok(new {id});
        }

        return BadRequest();
    }
}