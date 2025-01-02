using AutoMapper;
using LibraryTrackingApp.Application.CQRS.BookQueries.Book.Request;
using LibraryTrackingApp.Application.CQRS.BookQueries.Book.Response;
using LibraryTrackingApp.Application.Repository;
using MediatR;

namespace LibraryTrackingApp.Application.CQRS.Handlers.BookHandlers.QueryHandlers
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBookQueryRequest, IEnumerable<GetAllBookQueryResponse>>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public GetAllBooksQueryHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public Task<IEnumerable<GetAllBookQueryResponse>> Handle(GetAllBookQueryRequest request, CancellationToken cancellationToken)
        {
            var books = _bookRepository.GetAll();

            // Book -> DTO dönüşümü
            return Task.FromResult(_mapper.Map<IEnumerable<GetAllBookQueryResponse>>(books));
        }
    }
}
