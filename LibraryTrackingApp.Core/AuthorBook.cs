namespace LibraryTrackingApp.Core
{
    public class AuthorBook : BaseEntity
    {
        public int AuthorID { get; set; } // Yazar kimliği
        public int BookID { get; set; } // Kitap kimliği

        public Author Author { get; set; } = null!; // Yazar ilişkisi
        public Book Book { get; set; } = null!; // Kitap ilişkisi
    }
}