using LibraryTrackingApp.Core;

namespace LibraryTrackingApp.Application.Repository
{
    public interface IReservationRepository : IGenericRepository<Reservation>
    {
        IEnumerable<Reservation> GetActiveReservationsByUser(int userId); // Kullanıcıya ait aktif rezervasyonlar
        IEnumerable<Reservation> GetReservationsByBookCopy(int bookCopyId); // Kitap kopyasına ait rezervasyonlar
        IEnumerable<Reservation> GetOverdueReservations(); // Süresi dolmuş rezervasyonlar
        IEnumerable<Reservation> GetReservationsByStatus(int statusId); // Durum bazlı rezervasyonlar
    }
}
