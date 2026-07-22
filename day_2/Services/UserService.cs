using day_2.Dtos;
using Microsoft.AspNetCore.Http.HttpResults;

namespace day_2.Services
{
    public class UserService : IUserService
    {
        private readonly UserDto[] users =
        {
            new() { Id = 1, Name = "Mario", Age = 24 },
            new() { Id = 2, Name = "Luigi", Age = 23 },
            new() { Id = 3, Name = "Peach", Age = 22 }
        };


        public Task<UserDto> GetUserAsync(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                throw new KeyNotFoundException("User not found");
            }

            return Task.FromResult(user);
        }
    }
}
