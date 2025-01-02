using LibraryTrackingApp.Core;

namespace LibraryTrackingApp.Application.Repository
{
    public interface IBookEditionRepository : IGenericRepository<BookEdition>
    {
        IEnumerable<BookEdition> GetEditionsByBook(int bookId); // Kitaba ait baskıları getir
        IEnumerable<BookEdition> GetEditionsByFormat(int formatId); // Formata göre baskıları getir
    }
}
