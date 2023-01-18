using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using ReadStudentBooks.Data;
using ReadStudentBooks.Dto;
using ReadStudentBooks.Models;
using ReadStudentBooks.Models.Exceptions;
using System.Security.Cryptography;

namespace ReadStudentBooks.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public User GetUserByUsername(string username)
        {
            return _db.Users.First(user => user!.UserName.Equals(username));
        }

        public bool UserExist(string username)
        {
            return _db.Users.Any(user => user.UserName.Equals(username));
        }

        public User Register(UserDto userDto)
        {
            if(_db.Users.Any(user => user.UserName.Equals(userDto.Username)))
            {
                throw new UsernameExistException();
            }

            if(!userDto.Password.Equals(userDto.RepeatPassword)) 
            {
                throw new PasswordDontMatchException();
            }

            User user = new(
                userDto.Username,
                userDto.Name,
                userDto.LastName,
                HashedPassword(userDto.Password),userDto.Role);

            _db.Users.Add(user);
            _db.SaveChanges();

            return user;
        }

        public User Login(AuthorizationDto authorizationDto)
        {
            User? user = _db.Users.FirstOrDefault(u => u.UserName.Equals(authorizationDto.UserName));

            if (user == null)
            {
                throw new UserDontExistException();
            }

            if (!user.Password.Equals(HashedPassword(authorizationDto.Password)))
            {
                throw new PasswordDontMatchException();
            }

            return user;
        }


        private string HashedPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(128 / 8);
            // divide by 8 to convert bits to bytes

            // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password!,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            return hashedPassword;
        }
    }
}
