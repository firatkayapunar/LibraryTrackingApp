using LibraryTrackingApp.Core;

namespace LibraryTrackingApp.Application.Repository
{
    public interface IGenreRepository : IGenericRepository<Genre>
    {
        Genre? GetGenreByName(string name); // Tür adıyla tür getir
        IEnumerable<Genre> SearchGenres(string keyword); // Türleri ada göre ara
    }
}
