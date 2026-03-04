using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    
    [Table("Titles")]
    public class Title
    {
<<<<<<< HEAD
        public int emp_no { get; set; }

        public string title { get; set; }

        public string from_date { get; set; }

        public string? to_date { get; set; } 
=======
        
        [Key]
        [Column("emp_no", Order = 0)]
        public int emp_no { get; set; }

        
        [Key]
        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(90, ErrorMessage = "El título no puede exceder 90 caracteres")]
        [Column("title", Order = 1)]
        [Display(Name = "Título/Cargo")]
        public string title { get; set; } = string.Empty;

        
        [Key]
        [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
        [Column("from_date", Order = 2)]
        [DataType(DataType.DateTime)]
        [Display(Name = "Desde")]
        public DateTime from_date { get; set; }

        
        [Column("to_date")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Hasta")]
        public DateTime? to_date { get; set; }

        
        [ForeignKey("emp_no")]
        public virtual Employee? Employee { get; set; }
>>>>>>> ab9d61a046a156d1aa4ed248bd51915196a89e31
    }
}