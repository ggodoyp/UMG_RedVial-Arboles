using System.ComponentModel.DataAnnotations;

namespace RedVial_Arboles.Models
{
    public class Interseccion
    {
        public int idInterseccion { get; set; }
        public string nombreVia { get; set; }
        public int cantidadVehiculosEspera { get; set; }
        public string tipoViaNorte { get; set; }
        public string tipoViaSur { get; set; }
        public string tipoViaEste { get; set; }
        public string tipoViaOeste { get; set; }
        public bool semaforo { get; set; }
        public int tiempoPromedioTransito { get; set; }
        public string iTop { get; set; }
        public string iLeft { get; set; }
    }
}
