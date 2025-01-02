namespace LibraryTrackingApp.Core
{
    public class Book : BaseEntity
    {
        private readonly List<BookEdition> _bookEditions;
        private readonly List<AuthorBook> _authorBooks;

        public Book()
        {
            _bookEditions = new List<BookEdition>();
            _authorBooks = new List<AuthorBook>();
        }

        public string Name { get; set; } = string.Empty; // Kitap adı
        public int PublisherID { get; set; } // Yayıncı kimliği
        public int GenreID { get; set; } // Tür kimliği
        public string Summary { get; set; } = string.Empty; // Kitap özeti

        public Publisher Publisher { get; set; } = null!; // Yayıncı ilişkisi
        public Genre Genre { get; set; } = null!; // Tür ilişkisi
        public ICollection<BookEdition> BookEditions => _bookEditions; // Kitap baskılarıyla ilişkisi
        public ICollection<AuthorBook> AuthorBooks => _authorBooks; // Yazarlarla ilişkisi
    }
}
