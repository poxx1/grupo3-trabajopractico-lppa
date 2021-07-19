using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Marketplace.Entities.Models
{
    public class LogInModel: IdentityBase
    {
        [Required(ErrorMessage = "Requerido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [HiddenInput]
        public string ReturnUrl { get; set; }

    }
}