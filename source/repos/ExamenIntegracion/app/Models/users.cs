using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    
    [Table("users")]
    public class User
    {
        
        [Key]
        [Column("emp_no")]
        public int emp_no { get; set; }

        
        [Required(ErrorMessage = "El nombre de usuario es obligatorio")]
        [StringLength(100, ErrorMessage = "El usuario no puede exceder 100 caracteres")]
        [Column("usuario")]
        [Display(Name = "Usuario")]
        public string username { get; set; } = string.Empty;

        
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [StringLength(100)]
        [Column("clave")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string password { get; set; } = string.Empty;

        
        [StringLength(50)]
        [Column("role")]
        [Display(Name = "Rol")]
        public string role { get; set; } = "RRHH";

        
        [ForeignKey("emp_no")]
        public virtual Employee? Employee { get; set; }
    }
}