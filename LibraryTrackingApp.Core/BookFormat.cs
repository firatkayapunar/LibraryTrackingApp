namespace LibraryTrackingApp.Core
{
    public class BookFormat : BaseEntity
    {
        private readonly List<BookEdition> _bookEditions;

        public BookFormat(List<BookEdition> bookEdition)
        {
            _bookEditions = bookEdition;
        }

        public string FormatName { get; set; } = string.Empty; // Format adı (ör. Hardcover, Paperback)
        public ICollection<BookEdition> BookEditions => _bookEditions; // Kitap baskılarıyla ilişkisi
    }
}
