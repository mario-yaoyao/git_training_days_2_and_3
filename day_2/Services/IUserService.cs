using day_2.Dtos;

namespace day_2.Services
{
    public interface IUserService
    {
        public Task<List<UserDto>> GetUserAsync(int? id, int? age);
    }
}
