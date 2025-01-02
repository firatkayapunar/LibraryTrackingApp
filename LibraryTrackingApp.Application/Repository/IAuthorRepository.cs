using LibraryTrackingApp.Core;

namespace LibraryTrackingApp.Application.Repository
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        IEnumerable<Author> GetAuthorsByBook(int bookId); // Bir kitaba ait yazarları getir
        IEnumerable<Author> SearchAuthors(string keyword); // Yazarları ada/soyada göre ara
    }
}
