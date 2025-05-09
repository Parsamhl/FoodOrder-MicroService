using App.Domain.Core.User.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.DataAcess.User.Repositories
{
    internal class UserRepository : IUserRepository
    {
        public Task AddAsync(Domain.Core.User.Entities.User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Domain.Core.User.Entities.User>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Core.User.Entities.User> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
