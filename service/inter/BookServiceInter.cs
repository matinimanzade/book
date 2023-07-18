using BookManagmentSystem_C_.dto;

namespace BookManagmentSystem_C_.service.inter
{
    public interface BookServiceInter
    {
        public void createBook(CreateBookRequest requestBook);
        public List<BookDto> getAllBook();
        public BookDto getBookById();
        public void updateBook(UpdateBookRequest requestBook);
        public void deleteBook();
    }
}
