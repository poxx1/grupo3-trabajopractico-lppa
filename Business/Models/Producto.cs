using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Producto : IdentityBase
    {
        [Required(ErrorMessage = "Requerido")]
        [MaxLength(25)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [MaxLength(25)]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Requerido")]
        public float Precio { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [MaxLength(25)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [MaxLength(25)]
        public string Categoria { get; set; }

        // Imagen del producto
        [Required(ErrorMessage = "Requerido")]
        public byte[] Content { get; set; }
    }
}