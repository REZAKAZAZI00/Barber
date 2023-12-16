using Barber.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Barber.Context
{
    public class BarberDbContext:DbContext
    {
        public BarberDbContext(DbContextOptions<BarberDbContext> option):base(option)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Room>  Rooms { get; set; }
        public DbSet<FoodDrink>  FoodDrinks { get; set; }
        public DbSet<Payment>  Payments { get; set; }
        public DbSet<Equipment>  Equipment { get; set; }
        public DbSet<Orders>  Orders { get; set; }

    }
}
