using System.ComponentModel.DataAnnotations;

namespace Marketplace.Entities.Models
{
    public class OrderedProduct : IdentityBase
    {
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Requerido")]
        public virtual Product Product { get; set; }

        [Required(ErrorMessage = "Requerido")]
        public virtual CustomerOrder CustomerOrder { get; set; }
    }
}