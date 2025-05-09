
namespace App.Domain.Core.User.Data
{
    public interface IUserRepository
    {
        Task AddAsync(Entities.User user , CancellationToken cancellationToken);
        Task<List<Entities.User>> GetAllAsync(CancellationToken cancellationToken);    
        Task<Entities.User> GetByIdAsync(int id , CancellationToken cancellationToken);

    }
}
