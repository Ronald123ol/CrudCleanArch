using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCleanArch.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo titulo es obligatorio.")]
        [StringLength(50, ErrorMessage ="El {0} debe ser al menos {2} y máximo {1} caracteres", MinimumLength =3)]
        [Display(Name ="Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El campo Descripcion obligatorio.")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y máximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Descrición")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo Fecha es obligatorio.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Lanzamiento")]
        public DateTime Fecha_Lanzamiento { get; set; }
        [Required(ErrorMessage = "El campo Autor es obligatorio.")]
       
        public string Autor { get; set; }
        [Required(ErrorMessage = "El campo Precio es obligatorio.")]
        public int Precio { get; set; }
    }
}
