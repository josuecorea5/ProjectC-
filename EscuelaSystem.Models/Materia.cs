using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EscuelaSystem.Models
{
    public class Materia : EntityBase
    {
        [Required(ErrorMessage ="El campo código no puede estar vacío")]
        [MinLength(2, ErrorMessage ="El código debe ser mayor a 2 caracteres")]
        [MaxLength(20)]
        [Display(Name ="Codigo de Materia")]
        public string Codigo { get; set; }
        [Required(ErrorMessage ="El nombre de la materia no puede estar vacío")]
        [MinLength(3, ErrorMessage ="El nombre de materia debe ser mínimo 3 caracteres")]
        [MaxLength(25, ErrorMessage ="El nombre de la materia no debe exceder de los 25 caracteres")]
        [Display(Name = "Nombre de materia")] 
        public string Descripcion { get; set; }
        public bool Habilitada { get; set; }
    }
}
