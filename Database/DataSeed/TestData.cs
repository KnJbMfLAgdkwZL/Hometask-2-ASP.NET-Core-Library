using Database.DbContexts;
using Database.Models;

namespace Database.DataSeed;

public class TestData
{
    public static async Task SeedAsync(MasterContext masterContext)
    {
        var books = new List<Book>
        {
            new()
            {
                Id = 1,
                Title = "Sister Street Fighter (Onna hissatsu ken)",
                Cover = "http://dummyimage.com/121x100.png/dddddd/000000",
                Content = "Cross-platform tangible migration",
                Author = "Lynett Bernette",
                Genre = "Action"
            },
            new()
            {
                Id = 2,
                Title = "Jazz",
                Cover = "http://dummyimage.com/105x100.png/dddddd/000000",
                Content = "Multi-tiered client-driven circuit",
                Author = "Emlynne Humber",
                Genre = "Documentary"
            },
            new()
            {
                Id = 3,
                Title = "Meshes of the Afternoon",
                Cover = "http://dummyimage.com/234x100.png/5fa2dd/ffffff",
                Content = "Virtual responsive solution",
                Author = "Caryl Martill",
                Genre = "Fantasy"
            },
            new()
            {
                Id = 4,
                Title = "Artifact",
                Cover = "http://dummyimage.com/231x100.png/ff4444/ffffff",
                Content = "Customizable clear-thinking access",
                Author = "Tabitha Snary",
                Genre = "Documentary"
            },
            new()
            {
                Id = 5,
                Title = "Unforgiven, The",
                Cover = "http://dummyimage.com/111x100.png/ff4444/ffffff",
                Content = "Virtual asymmetric middleware",
                Author = "Faina Geany",
                Genre = "Western"
            },
            new()
            {
                Id = 6,
                Title = "Blue Steel",
                Cover = "http://dummyimage.com/238x100.png/5fa2dd/ffffff",
                Content = "Versatile attitude-oriented forecast",
                Author = "Hewitt Cudd",
                Genre = "Western"
            },
            new()
            {
                Id = 7,
                Title = "Mansfield Park",
                Cover = "http://dummyimage.com/247x100.png/cc0000/ffffff",
                Content = "Versatile bandwidth-monitored attitude",
                Author = "Sara Bramble",
                Genre = "Comedy"
            },
            new()
            {
                Id = 8,
                Title = "Ask Me Anything",
                Cover = "http://dummyimage.com/221x100.png/dddddd/000000",
                Content = "User-friendly system-worthy instruction set",
                Author = "Nicolai Allso",
                Genre = "Mystery"
            },
            new()
            {
                Id = 9,
                Title = "Dancing Outlaw II: Jesco Goes to Hollywood",
                Cover = "http://dummyimage.com/160x100.png/dddddd/000000",
                Content = "Distributed 24/7 function",
                Author = "Kerianne Baggally",
                Genre = "Documentary"
            },
            new()
            {
                Id = 10,
                Title = "Backlight",
                Cover = "http://dummyimage.com/136x100.png/ff4444/ffffff",
                Content = "Switchable next generation alliance",
                Author = "Earvin Goneau",
                Genre = "Sci-Fi"
            },
        };

        var ratings = new List<Rating>
        {
            new() {Id = 1, BookId = 6, Score = 3},
            new() {Id = 2, BookId = 2, Score = 3},
            new() {Id = 3, BookId = 7, Score = 4},
            new() {Id = 4, BookId = 10, Score = 2},
            new() {Id = 5, BookId = 10, Score = 2},
            new() {Id = 6, BookId = 9, Score = 1},
            new() {Id = 7, BookId = 1, Score = 2},
            new() {Id = 8, BookId = 9, Score = 1},
            new() {Id = 9, BookId = 4, Score = 1},
            new() {Id = 10, BookId = 9, Score = 2},
            new() {Id = 11, BookId = 1, Score = 1},
            new() {Id = 12, BookId = 4, Score = 3},
            new() {Id = 13, BookId = 6, Score = 1},
            new() {Id = 14, BookId = 5, Score = 3},
            new() {Id = 15, BookId = 3, Score = 1},
            new() {Id = 16, BookId = 8, Score = 1},
            new() {Id = 17, BookId = 3, Score = 4},
            new() {Id = 18, BookId = 4, Score = 5},
            new() {Id = 19, BookId = 6, Score = 3},
            new() {Id = 20, BookId = 6, Score = 4},
            new() {Id = 21, BookId = 7, Score = 3},
            new() {Id = 22, BookId = 1, Score = 3},
            new() {Id = 23, BookId = 2, Score = 5},
            new() {Id = 24, BookId = 5, Score = 3},
            new() {Id = 25, BookId = 5, Score = 2},
            new() {Id = 26, BookId = 2, Score = 5},
            new() {Id = 27, BookId = 3, Score = 1},
            new() {Id = 28, BookId = 9, Score = 2},
            new() {Id = 29, BookId = 6, Score = 5},
            new() {Id = 30, BookId = 10, Score = 5}
        };

        var reviews = new List<Review>
        {
            new()
            {
                Id = 1, Message = "id ornare imperdiet sapien urna pretium nisl", BookId = 10,
                Reviewer = "Trudi Braddock"
            },
            new()
            {
                Id = 2, Message = "integer tincidunt ante vel ipsum praesent blandit lacinia", BookId = 5,
                Reviewer = "Steve Algy"
            },
            new()
            {
                Id = 3, Message = "ultricies eu nibh quisque id justo sit amet sapien dignissim", BookId = 6,
                Reviewer = "Florry O'Cannan"
            },
            new()
            {
                Id = 4, Message = "potenti nullam porttitor lacus at turpis donec posuere metus", BookId = 7,
                Reviewer = "Quinta Sproson"
            },
            new() {Id = 5, Message = "sed justo pellentesque viverra pede", BookId = 6, Reviewer = "Lonnie Oglesbee"},
            new() {Id = 6, Message = "sed accumsan felis ut at dolor", BookId = 4, Reviewer = "Doroteya Korpolak"},
            new()
            {
                Id = 7, Message = "sapien iaculis congue vivamus metus arcu", BookId = 9, Reviewer = "Michael Routh"
            },
            new() {Id = 8, Message = "phasellus in felis donec semper sapien", BookId = 1, Reviewer = "Patti Keig"},
            new()
            {
                Id = 9, Message = "consectetuer adipiscing elit proin risus praesent lectus vestibulum quam",
                BookId = 5, Reviewer = "Dorotea acQuaker"
            },
            new()
            {
                Id = 10, Message = "quam a odio in hac habitasse platea dictumst maecenas", BookId = 2,
                Reviewer = "Cristobal Van Oord"
            },
            new()
            {
                Id = 11, Message = "aenean auctor gravida sem praesent id massa", BookId = 2,
                Reviewer = "Engelbert Jurkowski"
            },
            new()
            {
                Id = 12, Message = "felis eu sapien cursus vestibulum proin eu mi nulla", BookId = 1,
                Reviewer = "Carmella Blasl"
            },
            new()
            {
                Id = 13, Message = "dis parturient montes nascetur ridiculus mus vivamus vestibulum sagittis",
                BookId = 10, Reviewer = "Lalo Sawfoot"
            },
            new()
            {
                Id = 14, Message = "turpis integer aliquet massa id lobortis convallis tortor risus", BookId = 5,
                Reviewer = "Agathe Goning"
            },
            new()
            {
                Id = 15, Message = "sit amet nunc viverra dapibus nulla suscipit ligula in lacus", BookId = 6,
                Reviewer = "Don Snare"
            },
            new() {Id = 16, Message = "at lorem integer tincidunt ante", BookId = 3, Reviewer = "Lezley Bairstow"},
            new()
            {
                Id = 17, Message = "sem mauris laoreet ut rhoncus aliquet pulvinar", BookId = 2,
                Reviewer = "Audrye Boner"
            },
            new()
            {
                Id = 18, Message = "et eros vestibulum ac est lacinia nisi venenatis", BookId = 9,
                Reviewer = "Eyde Pilbury"
            },
            new()
            {
                Id = 19, Message = "in tempus sit amet sem fusce consequat nulla nisl nunc", BookId = 10,
                Reviewer = "Hobey Messier"
            },
            new()
            {
                Id = 20, Message = "ipsum ac tellus semper interdum mauris ullamcorper", BookId = 7,
                Reviewer = "Austin Henstone"
            },
            new()
            {
                Id = 21, Message = "blandit ultrices enim lorem ipsum dolor sit", BookId = 8,
                Reviewer = "Westley Delahunty"
            },
            new()
            {
                Id = 22, Message = "dapibus nulla suscipit ligula in lacus curabitur at ipsum ac", BookId = 6,
                Reviewer = "Emlynn Dellenbrook"
            },
            new()
            {
                Id = 23, Message = "in imperdiet et commodo vulputate justo in", BookId = 1, Reviewer = "Idalia Forkan"
            },
            new()
            {
                Id = 24, Message = "faucibus orci luctus et ultrices posuere cubilia curae nulla dapibus", BookId = 10,
                Reviewer = "Felipe Heffer"
            },
            new()
            {
                Id = 25, Message = "nec condimentum neque sapien placerat ante nulla", BookId = 9,
                Reviewer = "Blair Pettersen"
            },
            new()
            {
                Id = 26, Message = "ornare consequat lectus in est risus auctor", BookId = 1,
                Reviewer = "Tabbie Strother"
            },
            new()
            {
                Id = 27, Message = "nisl nunc nisl duis bibendum felis sed", BookId = 4, Reviewer = "Dania Pettifor"
            },
            new()
            {
                Id = 28, Message = "congue diam id ornare imperdiet sapien urna", BookId = 3, Reviewer = "Fraze Regina"
            },
            new()
            {
                Id = 29, Message = "ut ultrices vel augue vestibulum ante ipsum", BookId = 3, Reviewer = "Dex Stubbley"
            },
            new()
            {
                Id = 30, Message = "lorem id ligula suspendisse ornare consequat lectus in", BookId = 6,
                Reviewer = "Oberon Eckert"
            },
        };

        await masterContext.Books.AddRangeAsync(books);
        await masterContext.Ratings.AddRangeAsync(ratings);
        await masterContext.Reviews.AddRangeAsync(reviews);
        await masterContext.SaveChangesAsync();
    }
}