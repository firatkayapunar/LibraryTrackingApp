using LibraryTrackingApp.Application.CQRS.BookCommands.Book.Response;
using MediatR;

namespace LibraryTrackingApp.Application.CQRS.Commands.BookCommands.Request
{
    public class DeleteBookCommandRequest : IRequest<DeleteBookCommandResponse>
    {
        public int ID { get; set; }
    }
}
