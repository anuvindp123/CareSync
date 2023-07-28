using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_Wa.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }

        public string productName { get; set; }

        public string productDescription { get; set; }

        public decimal productPrice { get; set; }
    }
}
