using BookManagmentSystem_C_.dto;
using BookManagmentSystem_C_.service.impl;
using Microsoft.AspNetCore.Mvc;

namespace BookManagmentSystem_C_.controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookController : ControllerBase
    {
        BookService bookService;

        public BookController(BookService bookService) { this.bookService = bookService; }

        [HttpPost]
        public void createBook(CreateBookRequest request)
        {
            bookService.createBook(request);
        }

        [HttpGet]
        public List<BookDto> getAllBooks()
        {
            return bookService.getAllBook();
        }

        [HttpGet]
        public BookDto getBookById(long id)
        {
            return bookService.getBookById();
        }

        [HttpPut]
        public void updateBook(UpdateBookRequest updateBookRequest)
        {
            bookService.updateBook(updateBookRequest);
        }

        [HttpDelete]
        public void deleteBook(long id)
        {

        }
    }
}
