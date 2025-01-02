using LibraryTrackingApp.Application.CQRS.BookCommands.Book.Response;
using MediatR;

namespace LibraryTrackingApp.Application.CQRS.Commands.BookCommands.Request
{
    public class CreateBookCommandRequest : IRequest<CreateBookCommandResponse>
    {
        public string Name { get; set; } = string.Empty;
        public int PublisherId { get; set; }
        public int GenreId { get; set; }
        public string Summary { get; set; } = string.Empty;
    }
}
