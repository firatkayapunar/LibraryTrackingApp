using AutoMapper;
using LibraryTrackingApp.Application.CQRS.BookQueries.Book.Response;
using LibraryTrackingApp.Application.CQRS.Commands.BookCommands.Request;
using LibraryTrackingApp.Core;

namespace LibraryTrackingApp.Application.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            // Entity to DTO
            CreateMap<Book, GetBookByIdQueryResponse>();
            CreateMap<Book, GetAllBookQueryResponse>();

            // DTO to Entity
            CreateMap<CreateBookCommandRequest, Book>();
            CreateMap<UpdateBookCommandRequest, Book>();
        }
    }
}
