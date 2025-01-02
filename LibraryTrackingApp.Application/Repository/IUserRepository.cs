using LibraryTrackingApp.Core;

namespace LibraryTrackingApp.Application.Repository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User? GetUserByEmail(string email); // E-posta ile kullanıcı getir
        IEnumerable<User> GetUsersByReservation(int reservationId); // Rezervasyona göre kullanıcıları getir
        IEnumerable<User> SearchUsers(string keyword); // Kullanıcıları ada veya e-posta adresine göre ara
    }
}
