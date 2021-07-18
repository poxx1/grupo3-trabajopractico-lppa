using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Business.Models
{
    public class Users : IdentityBase
    {
        [Required(ErrorMessage = "Requerido")]
        [MaxLength(25)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [MaxLength(12)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [MaxLength(12)]
        public string Type { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [MaxLength(35)]
        [EmailAddress(ErrorMessage = "Email incorrecto")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [MaxLength(25)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [MaxLength(25)]
        public string Cuidad { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [MaxLength(25)]
        public string Provincia { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [MaxLength(10)]
        public string CodigoPostal { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [MaxLength(25)]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [MaxLength(12)]
        public string Telefono { get; set; }

    }
}
