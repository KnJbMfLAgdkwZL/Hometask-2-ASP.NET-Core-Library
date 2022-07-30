using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Business.Dto.In;

public class RatingDtoIn
{
    public int BookId;

    [FromBody]
    [Required(ErrorMessage = "Score can be from 1 to 5 ")]
    [Range(1, 5)]
    public byte Score { get; set; }
}