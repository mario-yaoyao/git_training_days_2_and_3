using day_2.Dtos;

namespace day_2.Services
{
    public interface IUserService
    {
        Task<UserDto> GetUserAsync(int id);
    }
}
