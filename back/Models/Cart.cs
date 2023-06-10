using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarBon.Models
{
    [Table("Cart")]
    public class Cart
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
    }
}
