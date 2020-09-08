using UserAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace UserAPI.Context
{
	public class ASAppContext : DbContext
	{
		public ASAppContext(DbContextOptions<ASAppContext> app) : base(app)
		{

		}
		
		public DbSet<User> Users { get; set; }
	}
}