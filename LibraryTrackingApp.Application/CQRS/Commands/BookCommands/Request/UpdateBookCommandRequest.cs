using LibraryTrackingApp.Application.CQRS.BookCommands.Book.Response;
using MediatR;

namespace LibraryTrackingApp.Application.CQRS.Commands.BookCommands.Request
{
    public class UpdateBookCommandRequest : IRequest<UpdateBookCommandResponse>
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int PublisherID { get; set; }
        public int GenreId { get; set; }
        public string Summary { get; set; } = string.Empty;
    }
}
