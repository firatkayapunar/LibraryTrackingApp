namespace LibraryTrackingApp.Core
{
    public class Reservation : BaseEntity
    {
        public int BookCopyID { get; set; } // Rezervasyon yapılan Kitap kimliği
        public int UserID { get; set; } // Rezervasyonu yapan kullanıcı kimliği
        public int ReservationStatusID { get; set; } // Rezervasyon durumu kimliği
        public DateTime ReservationDate { get; set; } // Rezervasyon tarihi
        public DateTime? DeliveryDate { get; set; } // Teslim tarihi
        public DateTime? BookReceivedDate { get; set; } // Kitap iade tarihi
        public int ReservedCopyCount { get; set; } // Rezervasyon yapılan kopya sayısı

        public BookCopy BookCopy { get; set; } = null!; // Kitap baskısı ilişkisi
        public User User { get; set; } = null!; // Kullanıcı ilişkisi
        public ReservationStatus ReservationStatus { get; set; } = null!; // Rezervasyon durumu
    }
}
