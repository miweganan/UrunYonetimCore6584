using Microsoft.EntityFrameworkCore;
using UrunYonetimCore6584.Core.Entities;

namespace UrunYonetimCore6584.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; } // veritabanı tablolarımızı temsil eden dbset ler
        public DbSet<Product> Products { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public DatabaseContext() : base("name=UrunYonetimiDb")
        {
            Database.SetInitializer(new DbInitializer()); // DbInitializer classımızı bu şekilde kurucu metotta çağırıyoruz çalışması için
        }

    }
}
