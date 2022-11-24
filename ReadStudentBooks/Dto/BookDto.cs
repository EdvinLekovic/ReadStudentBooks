namespace ReadStudentBooks.Dto
{
    public class BookDto
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public byte[] Content { get; set; }
        public DateTime DatePublished { get; set; }
    }
}
