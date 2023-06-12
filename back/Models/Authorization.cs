using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarBon.Models
{
    
    public class Authorization
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string login { get; set; }
        [Required]
        public string password { get; set; }

    }
}
