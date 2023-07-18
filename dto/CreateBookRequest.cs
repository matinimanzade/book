namespace BookManagmentSystem_C_.dto
{
    public class CreateBookRequest
    {
        public string Name;
        public string Author { get; set; }
        public DateTime Release_date { get; set; }

        public CreateBookRequest(string Name, string Author, DateTime Release_date)
        {
            this.Name = Name;
            this.Author = Author;
            this.Release_date = Release_date;

        }

        public CreateBookRequest()
        {

        }

        public override string ToString()
        {
            return $"CreateRequestBook : Name = {Name},Author = {Author},Release_date = {Release_date}";
        }
    }
}
