using LibraryTrackingApp.Application.CQRS.BookQueries.Book.Response;
using MediatR;

namespace LibraryTrackingApp.Application.CQRS.BookQueries.Book.Request
{
    public class GetAllBookQueryRequest : IRequest<IEnumerable<GetAllBookQueryResponse>>
    { }
}
