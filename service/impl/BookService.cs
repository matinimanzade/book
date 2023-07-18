using BookManagmentSystem_C_.dto;
using BookManagmentSystem_C_.mapper;
using BookManagmentSystem_C_.repository;
using BookManagmentSystem_C_.service.inter;
using Npgsql;

namespace BookManagmentSystem_C_.service.impl
{
    public class BookService : BookServiceInter
    {
        BookMapper bookMapper;

        public void createBook(CreateBookRequest requestBook)
        {
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand())
            {

            }
        }

        public void deleteBook()
        {

        }

        public List<BookDto> getAllBook()
        {

        }

        public BookDto getBookById()
        {

        }

        public void updateBook(UpdateBookRequest requestBook)
        {

        }
    }
}
