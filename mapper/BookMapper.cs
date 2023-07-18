using BookManagmentSystem_C_.dto;
using BookManagmentSystem_C_.model;
namespace BookManagmentSystem_C_.mapper
{
    public class BookMapper
    {
        public BookDto convertToBookDto(Book book)
        {
            BookDto bookDto = new BookDto();
            bookDto.Id = book.Id;
            bookDto.Book_name = book.Book_name;
            bookDto.Author = book.Author;
            bookDto.Release_date = bookDto.Release_date;
            return bookDto;
        }

        public Book convertToBook(CreateBookRequest request)        
        {
            Book book = new Book();
            book.Book_name = request.Name;
            book.Author = request.Author;

            return book;
        }

        public void updateBook(UpdateBookRequest request,Book book)
        {
            if (request.Name != null) { book.Book_name = request.Name; }
            if (request.Author != null) { book.Author = request.Author; }
            if (request.Release_date != null) { book.Release_date= request.Release_date; }
            
        }
    }
}
