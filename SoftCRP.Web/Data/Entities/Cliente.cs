using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftCRP.Web.Data.Entities
{
    public class Cliente
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El  campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "por favor completa este campo")]
        public string Nombre { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "por favor completa este campo")]
        public string Apellido { get; set; }

        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "por favor completa este campo")]
        public string Cedula { get; set; }

        [Display(Name = "Nombres")]

        public string FullName => $"{Nombre } {Apellido}";
    }
}
