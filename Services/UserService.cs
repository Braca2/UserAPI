using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Models;
using UserAPI.Interfaces;
using UserAPI.Repositories;

namespace UserAPI.Services
{
	public class UserService : IUserService
	{
		private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> Get()
		{
			return await userRepository.Get();
		}

		public async Task<User> Get(int id)
        {
			return await userRepository.Get(id);
        }

        public async Task<User> Insert(User user)
        {
            return await userRepository.Insert(user);
        }

        public async Task<User> Update(User user)
        {
            return await userRepository.Update(user);
        }

        public async Task Delete(User user)
        {
            await userRepository.Delete(user);
        }

    }
}
