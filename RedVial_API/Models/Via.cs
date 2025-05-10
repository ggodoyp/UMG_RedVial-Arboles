using System.ComponentModel.DataAnnotations;

namespace RedVial_API.Models
{
    public class Via
    {
        [Key]
        public int IdVia { get; set; }
        public string NombreVia { get; set; }
        public bool Unidireccional { get; set; } = false;
    }
}
