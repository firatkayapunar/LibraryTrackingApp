namespace LibraryTrackingApp.Application.CQRS.BookQueries.Book.Response
{
    public class GetAllBookQueryResponse
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
