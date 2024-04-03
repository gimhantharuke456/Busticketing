#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTicket.Models
{
    [Table("buses")]
    public class Bus
    {
        [Key]
        public int BusId { get; set; }

        [Required]
        [StringLength(50)]
        public string LicensePlate { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be greater than 0")]
        public int Capacity { get; set; }
    }
}
