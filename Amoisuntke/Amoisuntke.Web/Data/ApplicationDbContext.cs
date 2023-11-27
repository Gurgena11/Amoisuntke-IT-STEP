using Amoisuntke.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Amoisuntke.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "ვულკანის ჰაერის დამატენიანებელი",
                        Description = "ყოველდღიურ სტრესთან საბრძოლველად საჭიროა გვქონდეს ადგილი სადაც განიტვირთებით, ეს მოწყობილობა დაგეხმარებათ თქვენი გარემო მეტად მყუდრო და სასიამოვნო გახადოთ",
                        Color = "White",
                        Price = 185,
                        DiscountPrice = 125,
                        Coverage = 360,
                        ImageUrl = null,
                        IsExpired = false,
                        IsSecured = true,
                        Quantity = 5,
                        Splash = 36,
                        Tank = 30,
                        IsAroma = false,
                        IsHumidifier = true,
                    },

                    new Product
                    {
                        Id = 2,
                        Name = "ჰაერის დამატენიანებელი",
                        Description = "ყოველდღიურ სტრესთან საბრძოლველად საჭიროა გვქონდეს ადგილი სადაც განიტვირთებით, ეს მოწყობილობა დაგეხმარებათ თქვენი გარემო მეტად მყუდრო და სასიამოვნო გახადოთ",
                        Color = "Blue",
                        Price = 185,
                        DiscountPrice = 125,
                        Coverage = 360,
                        ImageUrl = null,
                        IsExpired = false,
                        IsSecured = true,
                        Quantity = 5,
                        Splash = 36,
                        Tank = 30,
                        IsAroma = false,
                        IsHumidifier = true
                    },

                    new Product
                    {
                        Id = 3,
                        Name = "სურნელოვანი ეთერზეთი - Tobacco Vanille 10ml",
                        Description = "არომატი რომლის აღწერაც არც თუ ისე მარტივია, ზედა ნოტებია თამბაქოს ფოთოლი და პიკანტური ნოტები, შუა ნოტებია თამბაქოს ყვავილი, ვანილი და კაკაო, საბაზო ნოტები ხმელი ხილი და ხის ნოტები",
                        Color = "Black",
                        Price = 25,
                        DiscountPrice = 0,
                        Coverage = 0,
                        ImageUrl = null,
                        IsExpired = false,
                        IsSecured = false,
                        Quantity = 15,
                        Splash = 10,
                        Tank = 0,
                        IsAroma = true,
                        IsHumidifier = false
                    }
                );
        }

    }
}
