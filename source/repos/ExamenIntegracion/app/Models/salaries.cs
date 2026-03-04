using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    
    [Table("Salaries")]
    public class Salary
    {
        
        [Key]
        [Column("emp_no", Order = 0)]
        public int emp_no { get; set; }

        
        [Required(ErrorMessage = "El salario es obligatorio")]
        [Column("salary")]
        [Range(0, int.MaxValue, ErrorMessage = "El salario debe ser un valor positivo")]
        [Display(Name = "Salario")]
        public int salary { get; set; }

        
        [Key]
        [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
        [Column("from_date", Order = 1)]
        [DataType(DataType.DateTime)]
        [Display(Name = "Vigente Desde")]
        public DateTime from_date { get; set; }

        
        [Column("to_date")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Vigente Hasta")]
        public DateTime? to_date { get; set; }

        
        [ForeignKey("emp_no")]
        public virtual Employee? Employee { get; set; }
    }
}
