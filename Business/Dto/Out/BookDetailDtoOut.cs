namespace Business.Dto.Out;

public class BookDetailDtoOut
{
    public int Id;
    public string Title = "";
    public string Author = "";
    public string Cover = "";
    public string Content = "";
    public double Rating;
    public List<BookReviewsDtoOut> Reviews = new();
}