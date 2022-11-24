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

        public User GetUserByUsername(UsernameDto usernameDto)
        {
            return _db.Users.First(user => user.Username.Equals(usernameDto.Username));
        }

        public User Register(UserDto userDto)
        {
            if(_db.Users.Any(user => user.Username.Equals(userDto.Username)))
            {
                throw new UsernameExistException();
            }
            if(!userDto.Password.Equals(userDto.RepeatPassword)) 
            {
                throw new PasswordDontMatchException();
            }

            byte[] salt = RandomNumberGenerator.GetBytes(128 / 8);
            // divide by 8 to convert bits to bytes

            // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: userDto.Password!,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            User user = new(userDto.Username, hashedPassword, userDto.Name, userDto.LastName);
            
            _db.Users.Add(user);
            _db.SaveChanges();

            return user;
        }
    }
}
