using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class IdentityBase
    {
        [Key]
        public int Id { get; set; }
    }
}