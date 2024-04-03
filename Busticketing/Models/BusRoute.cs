#nullable disable
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTicket.Models
{
    [Table("routes")]
    public class BusRoute
    {
        [Key]
        public int RouteId { get; set; }

        [Required]
        [StringLength(255)]
        public string Origin { get; set; }

        [Required]
        [StringLength(255)]
        public string Destination { get; set; }

        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        public int? BusId { get; set; }

        public Bus Bus { get; set; }
    }
}
