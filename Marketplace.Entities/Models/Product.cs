using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Marketplace.Entities.Models
{
    public class Product : IdentityBase
    {
        [Required(ErrorMessage = "Requerido")]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [MaxLength(50)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Requerido")]
        public double Price { get; set; }

        public DateTime LastUpdated { get; set; }

        [Required(ErrorMessage = "Requerido")]
        public int CategoryId  { get; set; }

    }
}