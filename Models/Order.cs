using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_Wa.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }

        [Required]
        public DateTime? orderDateStart { get; set; }

        [Required]
        public DateTime? orderDateDelivery { get; set; }

        [Required]
        public string addressDelivery { get; set; }

        [Required]
        public int productId { get; set; }

        [ForeignKey("productId")]
        public Product product { get; set; }

        [Required]
        public int teamId { get; set; }

        [ForeignKey("teamId")]
        public Team team { get; set; }

        [Required]
        public int vehicleId { get; set; }

        [ForeignKey("vehicleId")]
        public Vehicle vehicle { get; set; }
    }
}
