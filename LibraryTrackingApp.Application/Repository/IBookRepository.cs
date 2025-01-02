using LibraryTrackingApp.Core;

namespace LibraryTrackingApp.Application.Repository
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        IEnumerable<Book> GetBooksByGenre(int genreId); // Tür bazlı kitapları getir
        IEnumerable<Book> GetBooksByPublisher(int publisherId); // Yayıncı bazlı kitapları getir
        IEnumerable<Book> SearchBooks(string keyword); // Kitapları ada/özete göre ara
    }
}
