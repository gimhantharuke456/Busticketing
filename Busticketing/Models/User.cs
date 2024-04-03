#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTicket.Models
{

    [Table("users")]
    public class User
    {
        [Key] // Indicates that this is the Primary Key
        public int UserId { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string NIC { get; set; }

        [Required]
        [StringLength(255)]
        public string PasswordHash { get; set; }
    }
}
