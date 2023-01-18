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

        [HttpPost("register")]
        public User Register(UserDto userDto)
        {
            return this.userRepository.Register(userDto);
        }

        [HttpPost("login")]
        public User Login(AuthorizationDto authorizationDto)
        {
            return this.userRepository.Login(authorizationDto);
        }

        [HttpPost("get-user")]
        public User GetUser(string username)
        {
            return this.userRepository.GetUserByUsername(username);
        }
    }
}
