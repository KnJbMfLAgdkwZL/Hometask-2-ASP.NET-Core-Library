using System.ComponentModel.DataAnnotations.Schema;
using Database.Interfaces;

namespace Database.Models;

public sealed class Rating : IEntity
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public byte Score { get; set; }

    [ForeignKey("BookId")] public Book Book { get; set; } = null!;
}