using System;
using System.ComponentModel.DataAnnotations;

namespace Marketplace.Entities.Models
{
    public class Cart : IdentityBase
    {
        [Required(ErrorMessage = "Requerido")]
        public int CardId { get; set; }
        [Required(ErrorMessage = "Requerido")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Requerido")]
        public int Count { get; set; }
        [Required(ErrorMessage = "Requerido")]
        public DateTime DateCreated { get; set; }
        [Required(ErrorMessage = "Requerido")]
        public virtual Product Product { get; set; }
    }
}