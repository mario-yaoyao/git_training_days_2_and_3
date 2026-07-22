using day_2.Dtos;

namespace day_2.Services
{
    public class UserService : IUserService
    {
        private readonly UserDto[] users =
        {
            new() { Id = 1, Name = "Bowser", Age = 30 },
            new() { Id = 2, Name = "Mario", Age = 24 },
            new() { Id = 3, Name = "Luigi", Age = 23 },
            new() { Id = 4, Name = "Peach", Age = 22 },
        };

        public Task<List<UserDto>> GetUserAsync(int? id, int? age)
        {
            var matchingUsers = users.Where(u =>
                    (id == null || u.Id == id) &&
                    (age == null || u.Age == age)
                ).ToList();

            if (matchingUsers.Count == 0)
            {
                throw new KeyNotFoundException("User/s not found");
            }

            return Task.FromResult(matchingUsers);
        }
    }
}
