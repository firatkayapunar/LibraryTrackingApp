using LibraryTrackingApp.Core;

namespace LibraryTrackingApp.Application.Repository
{
    public interface IReservationStatusRepository : IGenericRepository<ReservationStatus>
    {
        ReservationStatus? GetStatusByName(string name); // Durum adıyla durum getir
        IEnumerable<ReservationStatus> GetStatuses(); // Tüm rezervasyon durumlarını getir
    }
}
