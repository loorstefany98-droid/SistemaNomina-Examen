using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    
    [Table("Log_AuditoriaSalarios")]
    public class log_AuditoriaSalarios
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }

        
        [Required(ErrorMessage = "El usuario es obligatorio")]
        [StringLength(50)]
        [Column("usuario")]
        [Display(Name = "Usuario")]
        public string usuario { get; set; } = string.Empty;

        
        [Required]
        [Column("fechaActualiz")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de Actualización")]
        public DateTime fechaActualiz { get; set; } = DateTime.Now;

        
        [Required(ErrorMessage = "El detalle del cambio es obligatorio")]
        [StringLength(250)]
        [Column("DetalleCambio")]
        [Display(Name = "Detalle del Cambio")]
        public string DetalleCambio { get; set; } = string.Empty;

        
        [Required]
        [Column("salario")]
        [Display(Name = "Nuevo Salario")]
        public long salario { get; set; }

        
        [Required]
        [Column("emp_no")]
        public int emp_no { get; set; }

        
        [ForeignKey("emp_no")]
        public virtual Employee? Employee { get; set; }
    }
}
