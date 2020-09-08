using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Context;
using UserAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace UserAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ASAppContext context;

        public UserRepository(ASAppContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<User>> Get()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> Get(int id)
        {
            return await context.Users.FindAsync(id);
        }

        public async Task<User> Insert(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();

            return user;
        }

        public async Task<User> Update(User user)
        {
            context.Entry(user).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return user;
        }

        public async Task Delete(User user)
        {
            context.Users.Remove(user);
            await context.SaveChangesAsync();
        }
    }
}
