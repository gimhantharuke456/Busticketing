#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTicket.Models
{
    [Table("seats")]
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }

        [Required]
        [StringLength(10)]
        public string SeatNumber { get; set; }

        public int BusId { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        public Bus Bus { get; set; }
    }
}
