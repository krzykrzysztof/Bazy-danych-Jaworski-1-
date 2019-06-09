using System;
using System.Collections.Generic;
using System.Text;
using HotelApplication.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>().ToTable("User").Property(p => p.Id).HasColumnName("UserId");     
            builder.Entity<IdentityRole>().ToTable("Role");

            var roomType1 = new RoomType() { Id = 1, Type = "Small" };
            var roomType2 = new RoomType() { Id = 2, Type = "Medium" };
            var roomType3 = new RoomType() { Id = 3, Type = "Large" };

            builder.Entity<RoomType>().HasData(
                roomType1,
                roomType2,
                roomType3);

            var room1 = new Room() { Id = 1, PeopleCount = 1, Price = 50, RoomTypeId = 1 };
            var room2 = new Room() { Id = 2, PeopleCount = 2, Price = 95, RoomTypeId = 2 };
            var room3 = new Room() { Id = 3, PeopleCount = 4, Price = 150, RoomTypeId = 3 };

            builder.Entity<Room>().HasData(
                room1,
                room2,
                room3
                );

            var relife1 = new Relief() { Id = 1, Discount = 20, Code = "Summer" };
            var relife2 = new Relief() { Id = 2, Discount = 10, Code = "2019" };
            var relife3 = new Relief() { Id = 3, Discount = 30, Code = "Holiday" };
            builder.Entity<Relief>().HasData(
                relife1,
                relife2,
                relife3);

            var payment1 = new Payment() { Id = Guid.NewGuid().ToString(), Price = 300, ReliefId = 3 };
            var payment2 = new Payment() { Id = Guid.NewGuid().ToString(), Price = 500, ReliefId = 1 };
            var payment3 = new Payment() { Id = Guid.NewGuid().ToString(), Price = 1000, ReliefId = 2 };
            builder.Entity<Payment>().HasData(
                payment1,
                payment2,
                payment3
                );
            var reservation1 = new Reservation() { Id = 1, RoomId = 1, PaymentId = payment1.Id, StartDate = new DateTime(2019, 5, 20), EndDate = new DateTime(2019, 5, 22) };
            var reservation2 = new Reservation() { Id = 2, RoomId = 2, PaymentId = payment2.Id, StartDate = new DateTime(2019, 1, 24), EndDate = new DateTime(2019, 1, 28) };
            var reservation3 = new Reservation() { Id = 3, RoomId = 3, PaymentId = payment3.Id, StartDate = new DateTime(2019, 2, 10), EndDate = new DateTime(2019, 2, 15) };
            builder.Entity<Reservation>().HasData(
                reservation1,
                reservation2,
                reservation3);
        }

        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Relief> Reliefs { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
