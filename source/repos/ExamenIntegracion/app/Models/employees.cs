using Microsoft.AspNetCore.Mvc;
using app.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    
    [Table("employees")]
    public class Employee
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("emp_no")]
        [Display(Name = "Número de Empleado")]
        public int emp_no { get; set; }

        
        [Required(ErrorMessage = "La cédula es obligatoria")]
        [StringLength(50, ErrorMessage = "La cédula no puede exceder 50 caracteres")]
        [Column("ci")]
        [Display(Name = "Cédula de Identidad")]
        public string ci { get; set; } = string.Empty;

       
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [Column("birth_date")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime birth_date { get; set; }

        
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder 50 caracteres")]
        [Column("first_name")]
        [Display(Name = "Nombre")]
        public string first_name { get; set; } = string.Empty;

      
        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(50, ErrorMessage = "El apellido no puede exceder 50 caracteres")]
        [Column("last_name")]
        [Display(Name = "Apellido")]
        public string last_name { get; set; } = string.Empty;

        
        [Required(ErrorMessage = "El género es obligatorio")]
        [StringLength(1)]
        [Column("gender")]
        [RegularExpression("^[MF]$", ErrorMessage = "El género debe ser M (Masculino) o F (Femenino)")]
        [Display(Name = "Género")]
        public string gender { get; set; } = string.Empty;

       
        [Required(ErrorMessage = "La fecha de contratación es obligatoria")]
        [Column("hire_date")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Contratación")]
        public DateTime hire_date { get; set; }

        
        [StringLength(100)]
        [Column("correo")]
        [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido")]
        [Display(Name = "Correo Electrónico")]
        public string? correo { get; set; }

        
        public virtual ICollection<Dept_Emp>? Dept_Emp { get; set; }

        
        public virtual ICollection<Dept_Manager>? Dept_Manager { get; set; }

        
        public virtual ICollection<Title>? Titles { get; set; }

        
        public virtual ICollection<Salary>? Salaries { get; set; }

        
        public virtual User? User { get; set; }

        
        public virtual ICollection<log_AuditoriaSalarios>? LogAuditorias { get; set; }
    }
}