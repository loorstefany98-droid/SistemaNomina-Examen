using System.ComponentModel.DataAnnotations;

namespace app.Models
{
    public class users
    {
        [Key]
        public int emp_no { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
    }
}