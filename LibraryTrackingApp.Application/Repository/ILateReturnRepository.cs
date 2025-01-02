using LibraryTrackingApp.Core;

namespace LibraryTrackingApp.Application.Repository
{
    public interface ILateReturnRepository : IGenericRepository<LateReturn>
    {
        IEnumerable<LateReturn> GetLateReturnsByUser(int userId); // Kullanıcıya ait gecikmiş iadeler
        IEnumerable<LateReturn> GetLateReturnsByBook(int bookId); // Kitaba ait gecikmiş iadeler
    }
}
