using Database.Interfaces;

namespace Database.Models;

public sealed class Book : IEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Cover { get; set; } = "";
    public string Content { get; set; } = "";
    public string Author { get; set; } = "";
    public string Genre { get; set; } = "";

    public List<Rating> Ratings { get; set; } = new();
    public List<Review> Reviews { get; set; } = new();
}