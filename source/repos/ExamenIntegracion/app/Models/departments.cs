using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> ab9d61a046a156d1aa4ed248bd51915196a89e31

namespace app.Models
{
    
    [Table("Departments")]
    public class Department
    {
<<<<<<< HEAD
        [Key]
        public int dept_no { get; set; }

        public string dept_name { get; set; }
=======
        
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
>>>>>>> ab9d61a046a156d1aa4ed248bd51915196a89e31
    }
}