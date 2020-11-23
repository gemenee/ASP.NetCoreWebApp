using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyGreatSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGreatSite.Models;

namespace MyGreatSite.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<FileEntity> Files { get; set; }
        public DbSet<TextField> TextFields { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "1F4C8722-7530-493E-895A-C0661F518337",
                Name = "admin",
                NormalizedName = "ADMIN",
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "9AC5FF00-78D8-42A5-AABD-D8C810061803",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "1F4C8722-7530-493E-895A-C0661F518337",
                UserId = "9AC5FF00-78D8-42A5-AABD-D8C810061803"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("4AF95BF3-8AD7-4443-B7B0-DA84309D80DE"),
                CodeWord = "PageIndex",
                Title = "Главная",
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("BC221C70-2C5B-44E7-BF31-19DC12DFE23F"),
                CodeWord = "PageServices",
                Title = "Наши услуги",
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("EADC257C-1DFE-47C4-99A9-D90CF6A3E22A"),
                CodeWord = "PageProducts",
                Title = "Наши товары"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("A8F5A04B-138B-42B6-9169-EC7F2F40AA52"),
                CodeWord = "PageArticles",
                Title = "Статьи"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("C6D70167-628E-44EB-83C1-A00BE290F6D9"),
                CodeWord = "PageFeedback",
                Title = "Отзывы"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("29085303-5753-455F-80E6-B2AE58D2911A"),
                CodeWord = "PageAbout",
                Title = "Обо мне"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("BB60E28D-3251-4119-A931-8C7908127B74"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
        }

        public DbSet<MyGreatSite.Models.LoginViewModel> LoginViewModel { get; set; }
    }
}
