using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Business.Dto.In;

public class ReviewDtoIn
{
    public int BookId;

    [FromBody]
    [Required(ErrorMessage = "Message not set")]
    public string Message { get; set; } = "";

    [FromBody]
    [Required(ErrorMessage = "Reviewer not set")]
    public string Reviewer { get; set; } = "";
}