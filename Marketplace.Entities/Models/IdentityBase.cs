using System.ComponentModel.DataAnnotations;

namespace Marketplace.Entities.Models
{
    public class IdentityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
