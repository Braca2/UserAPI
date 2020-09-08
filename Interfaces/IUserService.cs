using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace UserAPI.Interfaces
{
	public interface IUserService
	{
		Task<IEnumerable<User>> Get();
		Task<User> Get(int id);
		Task<User> Insert(User user);
		Task<User> Update(User user);
		Task Delete(User user);
    }
}
