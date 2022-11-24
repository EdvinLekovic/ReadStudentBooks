namespace ReadStudentBooks.Dto
{
    public class UserDto
    {
        public string Username { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty; 
        public string Password { get; set; } = string.Empty; 
        public string RepeatPassword { get; set; } = string.Empty;
    }
}
