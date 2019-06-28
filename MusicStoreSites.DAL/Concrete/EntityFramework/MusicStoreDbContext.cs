using MusicStoreSites.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreSites.DAL.Concrete.EntityFramework
{
    public class MusicStoreDbContext:DbContext
    {
        public MusicStoreDbContext():base("Data Source=.;Initial Catalog=MusicStoreSitesDB;User ID=sa;Password=123")
        {
            Database.SetInitializer(new MyStrategy());
        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<User> UserDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties().Where(a => a.PropertyType == typeof(DateTime)).Configure(a => a.HasColumnType("datetime2"));

            modelBuilder.Configurations.Add(new OrderDetailMapping());
        }

    }
}
