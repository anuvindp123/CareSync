using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_Wa.Models
{
    public class Team
    {
        [Key]
        public int id { get; set; }

        public string teamName { get; set; }

        public string teamDescription { get; set; }
    }
}
