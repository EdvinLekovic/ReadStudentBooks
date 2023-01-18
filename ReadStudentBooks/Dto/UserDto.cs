using ReadStudentBooks.Models.Enum;

namespace ReadStudentBooks.Dto
{
    public class UserDto
    {
        public string Username { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty; 
        public string Password { get; set; } = string.Empty; 
        public string RepeatPassword { get; set; } = string.Empty;
        public Role Role { get; set; }

        public UserDto(
            string username, 
            string name, 
            string lastName, 
            string password, 
            string repeatPassword, 
            Role role)
        {
            Username = username;
            Name = name;
            LastName = lastName;
            Password = password;
            RepeatPassword = repeatPassword;
            this.Role = role;
        }
    }
}
