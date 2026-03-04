using System.ComponentModel.DataAnnotations;

namespace app.Models
{
    public class Departments
    {
        [Key]
        public int dept_no { get; set; }

        public string dept_name { get; set; }
    }
}