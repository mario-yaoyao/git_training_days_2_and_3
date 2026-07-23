using day_2.Dtos;

namespace day_2.Services
{
    public interface IUserService
    {
        Task<List<UserDto>> GetUserAsync(int? id, string? name = null, int? age = null);
    }
}
