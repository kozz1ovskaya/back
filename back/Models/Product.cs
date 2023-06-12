using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarBon.Models
{
    [Table("Product")]
    public class Product
    {
        public int id { get; set; }
        public int price { get; set; }
        public string image { get; set; }
    }
}
