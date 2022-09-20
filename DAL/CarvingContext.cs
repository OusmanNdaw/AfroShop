using AfroShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace AfroShop.DAL
{
    public class CarvingContext : DbContext
    {
        public CarvingContext(string v)
        {
            if (v is null)
            {
                throw new ArgumentNullException(nameof(v));
            }
        }

        protected CarvingContext()
        {

        }

        public Microsoft.EntityFrameworkCore.DbSet<Carving> Carvingss { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Artist> Authors { get; set; }
        public void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
           // base.OnModelCreating(modelBuilder);
        }
    }
}

