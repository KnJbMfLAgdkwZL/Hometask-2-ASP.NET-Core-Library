using Database.Interfaces;

namespace Database.Models;

public sealed class Book : IEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Cover { get; set; } = null!;
    public string Content { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string Genre { get; set; } = null!;

    public List<Rating> Ratings { get; set; } = null!;
    public List<Review> Reviews { get; set; } = null!;
}