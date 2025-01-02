namespace LibraryTrackingApp.Application.CQRS.BookQueries.Book.Response
{
    public class GetBookByIdQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PublisherName { get; set; } = string.Empty;
        public string GenreName { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
    }
}
