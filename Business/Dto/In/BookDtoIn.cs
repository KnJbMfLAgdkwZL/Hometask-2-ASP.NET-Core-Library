using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Business.Dto.In;

public class BookDtoIn
{
    [FromBody]
    [Required(ErrorMessage = "Id not set")]
    public int Id { get; set; }

    [FromBody]
    [Required(ErrorMessage = "Title not set")]
    public string Title { get; set; } = "";

    [FromBody]
    [Required(ErrorMessage = "Cover not set")]
    public string Cover { get; set; } = "";

    [FromBody]
    [Required(ErrorMessage = "Content not set")]
    public string Content { get; set; } = "";

    [FromBody]
    [Required(ErrorMessage = "Genre not set")]
    public string Genre { get; set; } = "";

    [FromBody]
    [Required(ErrorMessage = "Author not set")]
    public string Author { get; set; } = "";
}