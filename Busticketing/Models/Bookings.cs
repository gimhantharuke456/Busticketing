#nullable disable
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTicket.Models
{
    [Table("bookings")]
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        public int UserId { get; set; }

        public int NumOfSeats { get; set; }

        public int RouteId { get; set; }

        [Required]
        public DateTime BookingTime { get; set; }
    }
}
