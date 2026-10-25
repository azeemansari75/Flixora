using Auth.DAL.ApplicationDbContext;
using Auth.DAL.Entities;
using Auth.DAL.RepositoriesContracts;
using Microsoft.EntityFrameworkCore;

namespace Auth.DAL.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDBContext _dbContext;

    public UserRepository(ApplicationDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<User?> GetUserByEmailAsync(string email)
    {
        return await _dbContext.Users
            .FirstOrDefaultAsync(u => u.Email == email);
    }

    public async Task<User?> GetUserByIdAsync(Guid userId)
    {
        return await _dbContext.Users
            .FirstOrDefaultAsync(u => u.UserId == userId);
    }

    public async Task<User> AddUserAsync(User user)
    {
        await _dbContext.Users.AddAsync(user);
        await _dbContext.SaveChangesAsync();

        return user;
    }

    public async Task<User> UpdateUserAsync(User user)
    {
        _dbContext.Users.Update(user);
        await _dbContext.SaveChangesAsync();

        return user;
    }
}