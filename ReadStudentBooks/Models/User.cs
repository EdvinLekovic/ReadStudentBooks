namespace ReadStudentBooks.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public User(string username, string password, string name, string lastName)
        {
            Username = username;
            Password = password;
            Name = name;
            LastName = lastName;
        }
    }
}
