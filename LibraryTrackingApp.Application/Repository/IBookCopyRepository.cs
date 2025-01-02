using LibraryTrackingApp.Core;

namespace LibraryTrackingApp.Application.Repository
{
    public interface IBookCopyRepository : IGenericRepository<BookCopy>
    {
        BookCopy? GetBookCopyBySerialNumber(Guid serialNumber); // Seri numarasıyla kitap kopyası getir
        IEnumerable<BookCopy> GetAvailableCopiesByEdition(int bookEditionId); // Mevcut kitap kopyalarını getir
        IEnumerable<BookCopy> GetBorrowedCopies(); // Ödünç alınmış kitap kopyalarını getir
    }
}
