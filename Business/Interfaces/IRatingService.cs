namespace Business.Interfaces;

public interface IRatingService
{
    Task RateAsync(int bookId, byte score, CancellationToken token);
}