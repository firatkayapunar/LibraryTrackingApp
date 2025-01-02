namespace LibraryTrackingApp.Core
{
    public class BookCopy : BaseEntity
    {
        private readonly List<Reservation> _reservations;

        public BookCopy(List<Reservation> reservations)
        {
            _reservations = reservations;
        }

        public Guid SerialNumber { get; set; } // Seri numarası (GUID)
        public int BookEditionId { get; set; } // Kitap baskı kimliği

        public BookEdition BookEdition { get; set; } = null!; // Format ilişkisi
        public ICollection<Reservation> Reservations => _reservations; // Rezervasyon ilişkisi
    }
}
