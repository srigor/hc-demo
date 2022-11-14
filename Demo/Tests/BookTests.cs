using Demo.Queries.GraphQL;
using FluentAssertions;
using Xunit;

namespace Demo.Tests
{
    public class BookTests
    {
        private readonly IBookClient _client;

        public BookTests(IBookClient client)
        {
            _client = client;
        }

        [Fact]
        public async void BookShouldHaveCorrectIdTest()
        {
            // Given
            var expectedBookId = decimal.Parse("72282500000000389969");
        
            // When
            var result = await _client.GetBook.ExecuteAsync();
            var actualBookId = result.Data.Book.BookIdentificationNumber;
        
            // Then
            actualBookId.Should().Be(expectedBookId);
        }
    }
}
