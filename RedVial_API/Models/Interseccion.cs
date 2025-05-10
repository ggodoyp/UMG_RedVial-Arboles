using System.ComponentModel.DataAnnotations;

namespace RedVial_API.Models
{
    public class Interseccion
    {
        [Key]
        public int IdInterseccion { get; set; }
        public string NombreVia { get; set; }
        public int CantidadVehiculosEspera { get; set; }
        public string TipoViaNorte { get; set; }
        public string TipoViaSur { get; set; }
        public string TipoViaEste { get; set; }
        public string TipoViaOeste { get; set; }
        public bool Semaforo { get; set; }
        public int TiempoPromedioTransito { get; set; }
        public string ITop { get; set; }
        public string ILeft { get; set; }
    }
}
