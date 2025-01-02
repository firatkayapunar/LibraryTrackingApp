namespace LibraryTrackingApp.Core
{
    public class Genre : BaseEntity
    {
        private readonly List<Book> _books;

        public Genre(List<Book> books)
        {
            _books = books;
        }
        public string Name { get; set; } = string.Empty; // Tür adı

        public ICollection<Book> Books => _books; // Kitaplarla ilişkisi
    }
}
