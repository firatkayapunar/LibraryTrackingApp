using LibraryTrackingApp.Application.CQRS.BookCommands.Book.Response;
using LibraryTrackingApp.Application.CQRS.Commands.BookCommands.Request;
using LibraryTrackingApp.Application.Repository;
using MediatR;

namespace LibraryTrackingApp.Application.CQRS.Handlers.Book.CommandHandlers
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommandRequest, DeleteBookCommandResponse>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IReservationRepository _reservationRepository;

        public DeleteBookCommandHandler(
           IBookRepository bookRepository,
           IReservationRepository reservationRepository)
        {
            _bookRepository = bookRepository;
            _reservationRepository = reservationRepository;
        }

        public Task<DeleteBookCommandResponse> Handle(DeleteBookCommandRequest request, CancellationToken cancellationToken)
        {
            // Kitap kontrolü
            var book = _bookRepository.GetById(request.ID);
            if (book == null)
                throw new KeyNotFoundException($"Kitap ID {request.ID} bulunamadı.");

            // Rezervasyon kontrolü
            //var reservations = _reservationRepository.GetReservationByBookId(request.Id);
            //if (reservations.Any())
            //    throw new InvalidOperationException("Kitap şu anda rezervasyonlu olduğu için silinemez.");

            // Silme işlemi
            _bookRepository.Delete(book.ID);

            return Task.FromResult(new DeleteBookCommandResponse
            {
                Message = "Kitap başarıyla silindi."
            });
        }
    }
}
