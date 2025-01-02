namespace LibraryTrackingApp.Core
{
    public class User : BaseEntity
    {
        private readonly List<Reservation> _reservations;

        public User(List<Reservation> reservations)
        {
            _reservations = reservations;
        }

        public string Name { get; set; } = string.Empty; // Kullanıcının adı
        public string Email { get; set; } = string.Empty; // Kullanıcının e-posta adresi
        public string IdentityNumber { get; set; } = string.Empty; // TC kimlik numarası
        public DateTime BirthDate { get; set; } // Doğum tarihi
        public string PhoneNumber { get; set; } = string.Empty; // Telefon numarası

        public ICollection<Reservation> Reservations => _reservations; // Kullanıcının rezervasyonları
    }
}
