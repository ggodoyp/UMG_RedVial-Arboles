using System.ComponentModel.DataAnnotations;

namespace RedVial_API.Models
{
    public class Ruta
    {
        [Key]
        public int IdRuta { get; set; }
        public int InterseccionOrigenId { get; set; }
        public int InterseccionDestinoId { get; set; }
        public int IdVia { get; set; } = 0;
    }
}
