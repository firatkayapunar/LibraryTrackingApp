using AutoMapper;
using LibraryTrackingApp.Application.CQRS.BookCommands.Book.Response;
using LibraryTrackingApp.Application.CQRS.Commands.BookCommands.Request;
using LibraryTrackingApp.Application.Repository;
using MediatR;

namespace LibraryTrackingApp.Application.CQRS.Handlers.BookHandlers.CommandHandlers
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommandRequest, CreateBookCommandResponse>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IPublisherRepository _publisherRepository;
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;

        public CreateBookCommandHandler(
           IBookRepository bookRepository,
           IAuthorRepository authorRepository,
           IPublisherRepository publisherRepository,
           IGenreRepository genreRepository,
           IMapper mapper)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _publisherRepository = publisherRepository;
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        public Task<CreateBookCommandResponse> Handle(CreateBookCommandRequest request, CancellationToken cancellationToken)
        {
            // Yayıncı kontrolü
            var publisher = _publisherRepository.GetById(request.PublisherId);
            if (publisher == null)
                throw new KeyNotFoundException($"Yayıncı ID {request.PublisherId} bulunamadı.");

            // Tür kontrolü
            var genre = _genreRepository.GetById(request.GenreId);
            if (genre == null)
                throw new KeyNotFoundException($"Tür ID {request.GenreId} bulunamadı.");

            // Kitap var mı kontrolü
            var existingBooks = _bookRepository.SearchBooks(request.Name);
            if (existingBooks.Any())
                throw new InvalidOperationException($"Bu isimde bir kitap zaten mevcut: {request.Name}");

            // Kitap oluşturma
            var book = _mapper.Map<Core.Book>(request);
            _bookRepository.Add(book);

            return Task.FromResult(new CreateBookCommandResponse
            {
                ID = book.ID,
                Message = "Kitap başarıyla oluşturuldu."
            });
        }
    }
}
