namespace LibraryTrackingApp.Core
{
    public class LateReturn : BaseEntity
    {
        public int ReservationID { get; set; } // Rezervasyon kimliği
        public int LateDay { get; set; } // Gecikme günü sayısı

        public Reservation Reservation { get; set; } = null!; // Rezervasyon ilişkisi
    }
}
