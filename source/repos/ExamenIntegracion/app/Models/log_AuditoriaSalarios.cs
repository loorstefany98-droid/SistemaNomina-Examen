using System;
using System.ComponentModel.DataAnnotations;

namespace app.Models
{
    public class log_AuditoriaSalarios
    {
        [Key]
        public int id { get; set; }

        public string usuario { get; set; }

        public DateTime fechaActualiz { get; set; }

        public string DetalleCambio { get; set; }

        public long salario { get; set; }

        public int emp_no { get; set; }
    }
}