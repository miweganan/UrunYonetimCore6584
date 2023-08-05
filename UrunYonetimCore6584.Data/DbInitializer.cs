using System.Data.Entity;
using UrunYonetimCore6584.Core.Entities;

namespace UrunYonetimCore6584.Data
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext> // CreateDatabaseIfNotExists<DatabaseContext> // eğer veritabanı yoksa DatabaseContext deki dbsetlere bakarak oluştur.
    {
        protected override void Seed(DatabaseContext context)
        {
            // seed metodu veritabanı oluştuktan sonra çalışır ve burada tablolara başlangıç kayıtları atabiliriz.
            if (!context.Users.Any()) // eğer veritabanında hiç kayıt yoksa
            {
                context.Users.Add(new AppUser()
                { // db deki users tablosuna aşağıdaki kaydı ekle
                    CreateDate = DateTime.Now,
                    Email = "admin@6584.com",
                    IsActive = true,
                    IsAdmin = true,
                    Name = "admin",
                    Username = "admin",
                    Password = "123"
                });
                context.SaveChanges(); // değişiklikleri db ye işle
            }
            base.Seed(context);
        }
    }
}
