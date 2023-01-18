using ReadStudentBooks.Dto;
using ReadStudentBooks.Models;
using ReadStudentBooks.Repository;

namespace ReadStudentBooks.Config
{
    public class DataConfiguration : BackgroundService
    {

        public readonly UserRepository userRepository;

        public DataConfiguration(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            User user = userRepository.GetUserByUsername("edvin");
            if (user == null)
            {
                this.userRepository.Register(
                    new UserDto(
                        "edvin",
                        "Edvin",
                        "Lekovic",
                        "edvin",
                        "edvin",
                        Models.Enum.Role.ADMIN));
            }
            return Task.CompletedTask;
        }
    }
}
