using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> ab9d61a046a156d1aa4ed248bd51915196a89e31

namespace app.Models
{
    
    [Table("Users")]
    public class User
    {
<<<<<<< HEAD
        [Key]
        public int emp_no { get; set; }   

        public string usuario { get; set; }

        public string clave { get; set; }
=======
        
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
>>>>>>> ab9d61a046a156d1aa4ed248bd51915196a89e31
    }
}