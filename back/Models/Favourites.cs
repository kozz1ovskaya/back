using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.Models
{
    [Table("Favourites")]
    public class Favourites
    {
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public long price { get; set; }
        [Required]
        public string image { get; set; }
    }
}
