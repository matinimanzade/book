namespace BookManagmentSystem_C_.dto
{
    public class BookDto
    {
        public long Id { get; set; }
        public string Book_name { get; set; }
        public string Author { get; set; }
        public DateOnly Release_date { get; set; }

        public BookDto() { }

        public BookDto(long Id, string Book_name, string Author, DateOnly Release_date)
        {
            this.Id = Id;
            this.Book_name = Book_name;
            this.Author = Author;
            this.Release_date = Release_date;
        }

        public override string ToString()
        {
            return $"Book : Id={Id},Book_name={Book_name},Author={Author},Release_date={Release_date}";
        }


    }
}
