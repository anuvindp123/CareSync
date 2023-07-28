using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_Wa.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        //Adotei 7 caracteres por conta do padrão mercosul. Exemplo: BRA7E197
        [Required]
        public string plateLicenseVehicle { get; set; }
    }
}
