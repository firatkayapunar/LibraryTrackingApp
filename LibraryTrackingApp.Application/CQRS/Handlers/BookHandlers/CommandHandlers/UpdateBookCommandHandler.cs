using AutoMapper;
using LibraryTrackingApp.Application.CQRS.BookCommands.Book.Response;
using LibraryTrackingApp.Application.CQRS.Commands.BookCommands.Request;
using LibraryTrackingApp.Application.Repository;
using MediatR;

namespace LibraryTrackingApp.Application.CQRS.Handlers.Book.CommandHandlers
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommandRequest, UpdateBookCommandResponse>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IPublisherRepository _publisherRepository;
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;

        public UpdateBookCommandHandler(
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

        public Task<UpdateBookCommandResponse> Handle(UpdateBookCommandRequest request, CancellationToken cancellationToken)
        {
            // Kitap kontrolü
            var book = _bookRepository.GetById(request.ID);
            if (book == null)
                throw new KeyNotFoundException($"Kitap ID {request.ID} bulunamadı.");

            // Yayıncı kontrolü
            var publisher = _publisherRepository.GetById(request.PublisherID);
            if (publisher == null)
                throw new KeyNotFoundException($"Yayıncı ID {request.PublisherID} bulunamadı.");

            // Tür kontrolü
            var genre = _genreRepository.GetById(request.GenreId);
            if (genre == null)
                throw new KeyNotFoundException($"Tür ID {request.GenreId} bulunamadı.");

            // Güncelleme işlemi
            _mapper.Map(request, book);
            _bookRepository.Update(book);

            return Task.FromResult(new UpdateBookCommandResponse
            {
                Message = "Kitap başarıyla güncellendi."
            });
        }
    }
}
