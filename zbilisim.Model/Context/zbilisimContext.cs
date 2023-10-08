using Microsoft.EntityFrameworkCore;
using zbilisim.Model.Entities;
using zbilisim.Model.Maps;

namespace zbilisim.Model.Context
{
    public class zbilisimContext:DbContext
    {
        public zbilisimContext(DbContextOptions<DbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FormMap());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<FormTable> FormTables { get; set; }

    }
}
