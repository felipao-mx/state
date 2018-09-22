using System;
using PT.Corporates.Flows.Models;
using Microsoft.EntityFrameworkCore;

namespace PT.Corporates.Flows.Repositories.Implem
{
	public class ReservationRepository : IReservationRepository
	{
		public Reservation GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Reservation GetByMasterLocatorId(int masterLocatorId)
		{
			throw new NotImplementedException();
		}

		public void Save(Reservation reservation)
		{
			throw new NotImplementedException();
		}

		private class ReservationDbContext : DbContext
		{
			public DbSet<Reservation> AuthProcess { get; set; }

			protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			{
				optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-8GHHEQ9\SQLEXPRESS;Initial Catalog=corporate;Integrated Security=True");
			}

			protected override void OnModelCreating(ModelBuilder modelBuilder)
			{
				modelBuilder.Entity<Reservation>().ToTable("reservation");
			}
		}
	}
}
