namespace LibraryTrackingApp.Core
{
    public class Publisher : BaseEntity
    {
        private readonly List<Book> _books;

        public Publisher(List<Book> books)
        {
            _books = books;
        }

        public string Name { get; set; } = string.Empty; // Yayıncı adı
        public string ContactInfo { get; set; } = string.Empty; // İletişim bilgileri

        public ICollection<Book> Books => _books; // Kitaplarla ilişkisi
    }
}
