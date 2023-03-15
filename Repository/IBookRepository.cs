using BookMicroservice.Models;

namespace BookMicroservice.Repository
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllBooksAsync();
        Task<Book> GetBookByIdAsync(int id);

        Task<Book> AddBookAsync(Book book);

        Task<Book> UpdateBookAsync(Book book);

        Task<Book> DeleteBookAsync(int id);
    }
}