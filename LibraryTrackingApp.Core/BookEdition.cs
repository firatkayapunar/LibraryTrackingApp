namespace LibraryTrackingApp.Core
{
    public class BookEdition : BaseEntity
    {
        private readonly List<Reservation> _reservations;

        public BookEdition(List<Reservation> reservations)
        {
            _reservations = reservations;
        }

        public int BookID { get; set; } // Kitap kimliği
        public int FormatID { get; set; } // Format kimliği
        public int EditionNumber { get; set; } // Baskı numarası
        public string ISBN { get; set; } = string.Empty; // ISBN numarası
        public DateTime ReleaseDate { get; set; } // Yayınlanma tarihi
        public int PageCount { get; set; } // Sayfa sayısı
        public int NumberOfCopy { get; set; } // Mevcut kopya sayısı

        public Book Book { get; set; } = null!; // Kitap ilişkisi
        public BookFormat BookFormat { get; set; } = null!; // Format ilişkisi
        public ICollection<Reservation> Reservations => _reservations; // Rezervasyon ilişkisi
    }
}
