public class Query
{
    public Book GetBook()
    {
        var bookId = decimal.Parse("72282500000000389969");

        return new Book
        {
            Title = "C# in depth.",
            BookIdentificationNumber = bookId,
            Author = new Author{
                Name = "Jon Skeet"
            }
        };
    }
}