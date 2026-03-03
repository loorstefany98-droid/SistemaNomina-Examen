using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    
    [Table("departments")]
    public class Department
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("dept_no")]
        public int dept_no { get; set; }

        
        [Required(ErrorMessage = "El nombre del departamento es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder 50 caracteres")]
        [Column("dept_name")]
        [Display(Name = "Nombre del Departamento")]
        public string dept_name { get; set; } = string.Empty;

        
        public virtual ICollection<Dept_Emp>? Dept_Emp { get; set; }

        
        public virtual ICollection<Dept_Manager>? Dept_Manager { get; set; }
    }
}
