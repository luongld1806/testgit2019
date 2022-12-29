using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using testgit2019.Areas.Identity.Data;
using testgit2019.Models;

namespace testgit2019.Data
{
    public class testgit2019Context : IdentityDbContext<User>
    {
        public DbSet<Table> Tables { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationDetail> ReservationDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public testgit2019Context(DbContextOptions<testgit2019Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CategoryDetail>().HasKey(detail => new { detail.FoodId, detail.CategoryId });
            builder.Entity<CategoryDetail>().HasOne<Food>(detail => detail.Food).WithMany(food => food.Categories).HasForeignKey(detail => detail.FoodId);
            builder.Entity<CategoryDetail>().HasOne<Category>(detail => detail.Category).WithMany(category => category.Foods).HasForeignKey(detail => detail.CategoryId);

            builder.Entity<OrderDetail>().HasKey(order => new { order.OrderId });
            builder.Entity<ReservationDetail>().HasKey(reserv => reserv.ReservationId);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
