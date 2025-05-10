using System.ComponentModel.DataAnnotations;

namespace RedVial_Arboles.Models
{
    public class Via
    {        
        public int IdVia { get; set; }
        public string? NombreVia { get; set; }
        public bool Unidireccional { get; set; } = false;
    }
}
