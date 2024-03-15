using ENTITY_FRAMEWORK_CRUD_OPS.Model;
using Microsoft.EntityFrameworkCore;

namespace ENTITY_FRAMEWORK_CRUD_OPS.Data
{
    public class EntityDb : DbContext
    {
        public readonly IConfiguration _Configuration;
        public string CString;
        public EntityDb(IConfiguration configuration)
        {
            _Configuration = configuration;
            CString = _Configuration["ConnectionStrings:DefualtConnection"];
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CString);
        }
        public DbSet<Entity> entities { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Entity>()
        //        .Property(p=>p.Age)
        //        .HasDefaultValue(22);
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
