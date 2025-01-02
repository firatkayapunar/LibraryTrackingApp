namespace LibraryTrackingApp.Application.CQRS.BookCommands.Book.Response
{
    public class CreateBookCommandResponse
    {
        public int ID { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
