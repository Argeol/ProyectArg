using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace ProyectArg.Models
{
    public class Employee
    {

        [Key]
        [SwaggerSchema(ReadOnly = true)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [StringLength(100, ErrorMessage = "El apellido no puede tener más de 100 caracteres.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El cargo es obligatorio.")]
        [StringLength(100, ErrorMessage = "El cargo no puede tener más de 100 caracteres.")]
        public string JobTitle { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Ingreso")]
        public DateTime HireDate { get; set; } = DateTime.Now;
    }
}
