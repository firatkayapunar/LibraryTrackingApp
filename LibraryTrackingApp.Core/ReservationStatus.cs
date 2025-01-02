namespace LibraryTrackingApp.Core
{
    public class ReservationStatus : BaseEntity
    {
        private readonly List<Reservation> _reservations;

        public ReservationStatus(List<Reservation> reservations)
        {
            _reservations = reservations;
        }

        public string Name { get; set; } = string.Empty; // Durum adı (Örn: "Onaylandı", "İptal Edildi")

        public ICollection<Reservation> Reservations => _reservations; // Rezervasyon ilişkisi
    }
}
