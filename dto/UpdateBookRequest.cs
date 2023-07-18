namespace BookManagmentSystem_C_.dto
{
    public class UpdateBookRequest
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public DateOnly Release_date { get; set; } 

        public UpdateBookRequest(string Name, string Author, DateOnly Release_date)
        { 
            this.Name = Name;
            this.Author = Author;
            this.Release_date = Release_date;
        }
        public UpdateBookRequest() { }
       
        public override string ToString() => "UpdateRequestBook : name = {name},author = {author},release_date = {release_date}";
    }
}
