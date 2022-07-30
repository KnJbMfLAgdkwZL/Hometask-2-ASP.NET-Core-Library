using Microsoft.EntityFrameworkCore;
using Database.Models;

namespace Database.DbContexts;

public class MasterContext : DbContext
{
    public MasterContext(DbContextOptions<MasterContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; } = null!;
    public virtual DbSet<Review> Reviews { get; set; } = null!;
    public virtual DbSet<Rating> Ratings { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id);
            entity.Property(e => e.Title).HasMaxLength(255).IsUnicode();
            entity.Property(e => e.Cover).HasMaxLength(255).IsUnicode();
            entity.Property(e => e.Content).HasMaxLength(255).IsUnicode();
            entity.Property(e => e.Author).HasMaxLength(255).IsUnicode();
            entity.Property(e => e.Genre).HasMaxLength(255).IsUnicode();

            entity.HasMany(book => book.Reviews).WithOne(review => review.Book);
            entity.HasMany(book => book.Ratings).WithOne(rating => rating.Book);
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id);
            entity.Property(e => e.Message).HasMaxLength(255).IsUnicode();
            entity.Property(e => e.BookId);
            entity.Property(e => e.Reviewer).HasMaxLength(255).IsUnicode();

            entity.HasOne(review => review.Book)
                .WithMany(book => book.Reviews)
                .HasForeignKey(review => review.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id);
            entity.Property(e => e.BookId);
            entity.Property(e => e.Score);

            entity.HasOne(review => review.Book)
                .WithMany(book => book.Ratings)
                .HasForeignKey(review => review.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });
    }
}