using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace FightGearProducts.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Boxing Gloves",
                        Description = "Red and black",
                        Category = "Boxing",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Shin Guards",
                        Description = "Elite shin guards - Khaki Camo",
                        Category = "Muay Thai",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Headgear",
                        Description = "The headgear boasts increadible lightness, excellent visibility and great absorption of blows",
                        Category = "Boxing",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Mouthguard",
                        Description = "Provides you a perfect custom fit",
                        Category = "Boxing",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "BJJ Gi",
                        Description = "The jacket is 100% cotton, perfectly combaining strength and comfort",
                        Category = "BJJ",
                        Price = 99.99m
                    },
                    new Product
                    {
                        Name = "BJJ White belt",
                        Description = "Thick, Sturdy, 100% Cotton",
                        Category = "BJJ",
                        Price = 16m
                    },
                    new Product
                    {
                        Name = "BJJ Black belt",
                        Description = "Thick, Sturdy, 100% Cotton",
                        Category = "BJJ",
                        Price = 16m
                    },
                    new Product
                    {
                        Name = "Muay Thai shorts",
                        Description = "Their high quality, flexible and lightweight fabric leaves you unrestricted and will withstand your intensive training.",
                        Category = "Muay Thai",
                        Price = 45.99m
                    },
                    new Product
                    {
                        Name = "Elbow Protector",
                        Description = "High quality cotton. Ultimate elbow pads to practice safely Muay Thai and MMA",
                        Category = "Muay Thai",
                        Price = 30.99m
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
