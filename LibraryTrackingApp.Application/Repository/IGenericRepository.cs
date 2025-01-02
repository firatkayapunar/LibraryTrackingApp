using LibraryTrackingApp.Core;

namespace LibraryTrackingApp.Application.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T? GetById(int id); // ID ile veri getir
        IEnumerable<T> GetAll(); // Tüm veriyi getir
        void Add(T entity); // Yeni bir veri ekle
        void Update(T entity); // Mevcut veriyi güncelle
        void Delete(int id); // Veriyi sil
        bool Exists(int id); // Bir ID'nin varlığını kontrol et
    }
}
