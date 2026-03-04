using System.ComponentModel.DataAnnotations;

namespace app.Models
{
    public class employees
    {
        [Key]
        public int emp_no { get; set; }

        public string ci { get; set; }
        public string birth_date { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public string hire_date { get; set; }
        public string correo { get; set; }
    }
}