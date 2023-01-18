namespace ReadStudentBooks.Dto
{
    public class UpdateBookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime DatePublished { get; set; }
    }
}
