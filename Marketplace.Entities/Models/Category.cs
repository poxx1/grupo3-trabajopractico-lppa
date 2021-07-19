using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Marketplace.Entities.Models
{
    public class Category : IdentityBase
    {
        [Required(ErrorMessage = "Requerido")]
        [MaxLength(20)]
        public string Name { get; set; }
        public virtual ICollection<Product> Products{ get; set; }
    }
}