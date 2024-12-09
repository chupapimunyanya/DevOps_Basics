using Xunit;
using DevOps_Basics;

namespace DevOps_Basics_Tests
{

    public class BookTests
    {
        [Fact]
        public void Book_ShouldInitializeCorrectly()
        {
            // Arrange
            var title = "Test Title";
            var author = "Test Author";
            var year = 2023;

            // Act
            var book = new Book(title, author, year);

            // Assert
            Assert.Equal(title, book.Title);
            Assert.Equal(author, book.Author);
            Assert.Equal(year, book.Year);
        }

        [Fact]
        public void ToString_ShouldReturnCorrectFormat()
        {
            // Arrange
            var book = new Book("Test Title", "Test Author", 2023);
            var expectedString = "\"Test Title\" by Test Author, 2023";

            // Act
            var result = book.ToString();

            // Assert
            Assert.Equal(expectedString, result);
        }
    }
}
