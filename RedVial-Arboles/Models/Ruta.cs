using System.ComponentModel.DataAnnotations;

namespace RedVial_Arboles.Models
{
    public class Ruta
    {
        public int IdRuta { get; set; }
        public int InterseccionOrigenId { get; set; }
        public int InterseccionDestinoId { get; set; }
        public int IdVia { get; set; } = 0;
    }
}
