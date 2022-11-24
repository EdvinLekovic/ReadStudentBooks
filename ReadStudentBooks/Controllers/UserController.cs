using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadStudentBooks.Dto;
using ReadStudentBooks.Models;
using ReadStudentBooks.Repository;

namespace ReadStudentBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpPost("/register")]
        public User register(UserDto userDto)
        {
            return this.userRepository.Register(userDto);
        }

        [HttpPost("/get-user")]
        public User GetUser(UsernameDto userDto)
        {
            return this.userRepository.GetUserByUsername(userDto);
        }
    }
}
