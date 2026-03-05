using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    [Table("salaries")]
    public class salaries
    {
        [Key, Column(Order = 0)]
        public int emp_no { get; set; }

        [Key, Column(Order = 1)]
        public string from_date { get; set; } = "";

        public long salary { get; set; }

        public string? to_date { get; set; }
    }
}