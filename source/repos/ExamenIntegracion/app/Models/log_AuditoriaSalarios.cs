using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    [Table("log_AuditoriaSalarios")]
    public class log_AuditoriaSalarios
    {
        [Key]
        public int id { get; set; }

        public string usuario { get; set; } = "";

        public DateTime fechaActualiz { get; set; }  

        public string DetalleCambio { get; set; } = "";

        public long salario { get; set; }

        public int emp_no { get; set; }
    }
}