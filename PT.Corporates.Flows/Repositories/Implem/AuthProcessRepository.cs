using Microsoft.EntityFrameworkCore;
using PT.Corporates.Flows.Models;

namespace PT.Corporates.Flows.Repositories.Implem
{
	public class AuthProcessRepository : IAuthProcessRepository
	{
		private AuthProcessDbContext dbContext;

		public AuthorizationProcess GetById(int id)
		{
			return dbContext.AuthProcess.Find(id);
		}

		public void Save(AuthorizationProcess authorizationProcess)
		{
			dbContext.AuthProcess.Add(authorizationProcess);
			dbContext.SaveChanges();
		}

		public void Update(AuthorizationProcess authorizationProcess)
		{
			throw new System.NotImplementedException();
		}

		private class AuthProcessDbContext : DbContext
		{
			public DbSet<AuthorizationProcess> AuthProcess { get; set; }

			protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			{
				optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-8GHHEQ9\SQLEXPRESS;Initial Catalog=corporate;Integrated Security=True");
			}

			protected override void OnModelCreating(ModelBuilder modelBuilder)
			{
				modelBuilder.Entity<AuthorizationProcess>().ToTable("authorizationProcess");
			}
		}
	}
}
