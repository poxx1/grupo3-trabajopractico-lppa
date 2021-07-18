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
        [MaxLength(35)]
        [EmailAddress(ErrorMessage = "Email incorrecto")]
        public string Email { get; set; }
    }
}
