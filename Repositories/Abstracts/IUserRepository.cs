using BusinessApp.Entities;

namespace BusinessApp.Repositories.Abstracts
{
  public interface IUserRepository : IRepository<User>
  {
    Task<IEnumerable<User>> GetAllUserAsync();
    Task UpdateUserAsync(User user);
  }
}