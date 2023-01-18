namespace ReadStudentBooks.Dto
{
    public class AddBookDto
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public byte[]? Content { get; set; }
        public byte[]? Image { get; set; }
        public long Price { get; set; }
    }
}
