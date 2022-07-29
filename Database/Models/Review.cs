using System.ComponentModel.DataAnnotations.Schema;
using Database.Interfaces;

namespace Database.Models;

public sealed class Review : IEntity
{
    public int Id { get; set; }
    public string Message { get; set; } = null!;
    public int BookId { get; set; }
    public string Reviewer { get; set; } = null!;

    [ForeignKey("BookId")] public Book Book { get; set; } = null!;
}