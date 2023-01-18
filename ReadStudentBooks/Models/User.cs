using ReadStudentBooks.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace ReadStudentBooks.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User(
            string userName, 
            string name, 
            string lastName, 
            string password, 
            Role role)
        {
            UserName = userName;
            Name = name;
            LastName = lastName;
            Password = password;
            Role = role;
        }
    }
}
