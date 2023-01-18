using ReadStudentBooks.Dto;
using ReadStudentBooks.Models;

namespace ReadStudentBooks.Repository
{
    public interface IUserRepository
    {
        public User Register(UserDto userDto);
        public User Login(AuthorizationDto authorizationDto);
        public User GetUserByUsername(string username);
        public bool UserExist(string username);
    }
}
