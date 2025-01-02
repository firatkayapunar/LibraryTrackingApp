using LibraryTrackingApp.Core;

namespace LibraryTrackingApp.Application.Repository
{
    public interface IPublisherRepository : IGenericRepository<Publisher>
    {
        Publisher? GetPublisherByName(string name); // Yayıncı adıyla yayıncı getir
        IEnumerable<Publisher> SearchPublishers(string keyword); // Yayıncıları ada göre ara
    }
}
