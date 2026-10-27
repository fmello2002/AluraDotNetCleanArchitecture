using Microsoft.EntityFrameworkCore;
using ScheduleAPI.Domain.Entities;

namespace ScheduleAPI.Infrastructure.Persistence
{
    public class ScheduleDbContext : DbContext
    {
        public ScheduleDbContext(DbContextOptions<ScheduleDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<Agendamento> Agendamentos { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aplica automaticamente todas as IEntityTypeConfiguration da montagem Infrastructure
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ScheduleDbContext).Assembly);
        }
    }
}