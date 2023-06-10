using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarBon.Models
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
    }
}
