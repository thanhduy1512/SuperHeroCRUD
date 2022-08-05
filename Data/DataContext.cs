using System;
using Microsoft.EntityFrameworkCore;

namespace SuperHero2.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}

