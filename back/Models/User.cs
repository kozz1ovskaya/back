using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarBon.Models
{
    [Table("UserLogin")]
    //public class User
    //{
    //    [Required]
    //    public string? id { get; set; }
    //    [Required]
    //    public string login { get; set; }
    //    [Required]
    //    public string password { get; set; }
    //    [Required]
    //    public string? email { get; set; }
    //    [Required]
    //    public string name { get; set; }
    //    [Required]
    //    public string? phone { get; set; }
    //}


    public class User
    {
        [Required]
        public int? id { get; set; }
        [Required]
        public string? name { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public long? phone { get; set; }
        [Required]
        public string? login { get; set; }
        [Required]
        public string? password { get; set; }

    }
}
