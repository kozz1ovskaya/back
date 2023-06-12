using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarBon.Models
{
    [Table("Order")]
    public class Order
    {
        public int id { get; set; }
        public string title { get; set; }
        public long price { get; set; }
        public string image { get; set; }
    }
}
