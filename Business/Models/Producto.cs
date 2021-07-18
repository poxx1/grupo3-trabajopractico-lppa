using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Entities.Models
{
    public class Producto : IdentityBase
    {
        [Required(ErrorMessage = "Requerido")]
        [MaxLength(25)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [MaxLength(25)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [MaxLength(35)]
        [EmailAddress(ErrorMessage = "Email incorrecto")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [DisplayName("Teléfono")]
        public long Telefono { get; set; }

        [Required(ErrorMessage = "Requerido")]
        public long Cuit { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return Nombre + " " + Apellido;
            }
        }
    }
}