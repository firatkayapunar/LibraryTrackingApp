namespace LibraryTrackingApp.Core
{
    public class Author : BaseEntity
    {
        private readonly List<AuthorBook> _authorBooks;

        public Author()
        {
            _authorBooks = new List<AuthorBook>();
        }

        public string Name { get; set; } = string.Empty; // Yazarın adı
        public string Surname { get; set; } = string.Empty; // Yazarın soyadı
        public string Biography { get; set; } = string.Empty; // Yazarın biyografisi

        public ICollection<AuthorBook> AuthorBooks => _authorBooks; // Yazarın kitaplarıyla ilişkisi
    }
}
