using Auth.DAL.Entities;

namespace Auth.DAL.RepositoriesContracts;

public interface IUserRepository
{
    Task<User?> GetUserByEmailAsync(string email);

    Task<User?> GetUserByIdAsync(Guid userId);

    Task<User> AddUserAsync(User user);

    Task<User> UpdateUserAsync(User user);
}
