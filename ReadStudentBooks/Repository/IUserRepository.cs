using ReadStudentBooks.Dto;
using ReadStudentBooks.Models;

namespace ReadStudentBooks.Repository
{
    public interface IUserRepository
    {
        public User Register(UserDto userDto);
        public User GetUserByUsername(UsernameDto usernameDto);
    }
}
