using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_Wa.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string userName { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string role { get; set; }
    }
}
