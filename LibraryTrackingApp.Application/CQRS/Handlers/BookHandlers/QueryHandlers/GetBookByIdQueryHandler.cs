using AutoMapper;
using LibraryTrackingApp.Application.CQRS.BookQueries.Book.Request;
using LibraryTrackingApp.Application.CQRS.BookQueries.Book.Response;
using LibraryTrackingApp.Application.Repository;
using MediatR;

namespace LibraryTrackingApp.Application.CQRS.Handlers.BookHandlers.QueryHandlers
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQueryRequest, GetBookByIdQueryResponse>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IPublisherRepository _publisherRepository;
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;

        public GetBookByIdQueryHandler(
            IBookRepository bookRepository,
            IPublisherRepository publisherRepository,
            IGenreRepository genreRepository,
            IMapper mapper)
        {
            _bookRepository = bookRepository;
            _publisherRepository = publisherRepository;
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        public Task<GetBookByIdQueryResponse> Handle(GetBookByIdQueryRequest request, CancellationToken cancellationToken)
        {
            // Kitap var mı kontrol et
            var book = _bookRepository.GetById(request.ID);

            if (book == null)
                throw new KeyNotFoundException($"Kitap ID {request.ID} bulunamadı.");

            // Publisher ve Genre bilgilerini getir
            var publisher = _publisherRepository.GetById(book.PublisherID);
            var genre = _genreRepository.GetById(book.GenreID);

            // Book -> DTO dönüşümü
            var response = _mapper.Map<GetBookByIdQueryResponse>(book);
            response.PublisherName = publisher?.Name ?? "Bilinmiyor";
            response.GenreName = genre?.Name ?? "Bilinmiyor";

            return Task.FromResult(response);
        }
    }
}
