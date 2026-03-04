using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    
    [Table("dept_emp")]
    public class Dept_Emp
    {
        
        [Key]
        [Column("emp_no", Order = 0)]
        public int emp_no { get; set; }

        
        [Key]
        [Required(ErrorMessage = "El departamento es obligatorio")]
        [Column("dept_no", Order = 1)]
        public int dept_no { get; set; }

        
        [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
        [Column("from_date")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de Inicio")]
        public DateTime from_date { get; set; }

        
        [Required(ErrorMessage = "La fecha de fin es obligatoria")]
        [Column("to_date")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de Fin")]
        public DateTime to_date { get; set; }

        
        [ForeignKey("emp_no")]
        public virtual Employee? Employee { get; set; }

        
        [ForeignKey("dept_no")]
        public virtual Department? Department { get; set; }
    }
}

