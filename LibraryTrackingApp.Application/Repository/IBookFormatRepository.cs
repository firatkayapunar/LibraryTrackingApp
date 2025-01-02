using LibraryTrackingApp.Core;

namespace LibraryTrackingApp.Application.Repository
{
    public interface IBookFormatRepository : IGenericRepository<BookFormat>
    {
        BookFormat? GetFormatByName(string name); // Format adıyla format getir
        IEnumerable<BookFormat> GetAllFormats(); // Tüm formatları getir
    }
}
