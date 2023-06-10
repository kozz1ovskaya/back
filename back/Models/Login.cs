using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarBon.Models
{
    [Table("UserLogin")]
    public class Login
    {

        public string Log { get; set; }
        public string Password { get; set; }

    }
}
