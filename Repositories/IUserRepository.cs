using UserAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAPI.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> Get();
        Task<User> Get(int id);
        Task<User> Insert(User user);
        Task<User> Update(User user);
        Task Delete(User user);
    }
}
