using Business.Dto.In;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIWeb.Controllers;

[ApiController]
[Produces("application/json")]
public class RatingController : Controller
{
    private readonly IRatingService _ratingService;

    public RatingController(IRatingService ratingService)
    {
        _ratingService = ratingService;
    }

    [HttpPost]
    [Route("api/books/{bookId:int}/rate")]
    public async Task<IActionResult> Save(CancellationToken token, [FromRoute] int bookId,
        [FromBody] RatingDtoIn ratingDtoIn)
    {
        if (ModelState.IsValid)
        {
            ratingDtoIn.BookId = bookId;
            var id = await _ratingService.RateAsync(ratingDtoIn, token);
            return Ok(new {id});
        }

        return BadRequest();
    }
}