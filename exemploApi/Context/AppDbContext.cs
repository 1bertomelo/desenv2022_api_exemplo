
using exemploApi.Models;
using Microsoft.EntityFrameworkCore;

namespace exemploApi.Context
{
	public class AppDbContext : DbContext
	{
        public AppDbContext()
        { }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
        public virtual DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
