using Microsoft.EntityFrameworkCore;
using BusTicket.Models;

namespace busticketing.Data
{
    public class BusTicketDbContext : DbContext
    {
        public BusTicketDbContext(DbContextOptions<BusTicketDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<BusRoute> BusRoutes { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Bus> Buses { get; set; }
    }
}
