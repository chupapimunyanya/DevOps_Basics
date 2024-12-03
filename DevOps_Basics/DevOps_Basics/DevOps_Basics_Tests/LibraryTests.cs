using DevOps_Basics;

namespace DevOps_Basics_Tests
{
    public class LibraryTests
    {
        [Fact]
        public void AddBook_ShouldAddBookToLibrary()
        {
            // Arrange
            var library = new Library();
            var book = new Book("Test Title", "Test Author", 2023);

            // Act
            library.AddBook(book);

            // Assert
            Assert.Contains(book, library.Books);
        }

        [Fact]
        public void FindBookByTitle_ShouldReturnCorrectBook()
        {
            // Arrange
            var library = new Library();
            var book1 = new Book("Test Title", "Test Author", 2023);
            var book2 = new Book("Another Title", "Another Author", 2022);
            library.AddBook(book1);
            library.AddBook(book2);

            // Act
            var result = library.FindBookByTitle("Test Title");

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Test Title", result.Title);
            Assert.Equal("Test Author", result.Author);
        }

        [Fact]
        public void FindBookByTitle_ShouldReturnNullIfNotFound()
        {
            // Arrange
            var library = new Library();
            var book = new Book("Test Title", "Test Author", 2023);
            library.AddBook(book);

            // Act
            var result = library.FindBookByTitle("Nonexistent Title");

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void DisplayBooks_ShouldWorkForEmptyLibrary()
        {
            // Arrange
            var library = new Library();

            // Act & Assert
            var exception = Record.Exception(() => library.DisplayBooks());
            Assert.Null(exception); // Перевіряємо, що метод не викликає виключень
        }
    }
}