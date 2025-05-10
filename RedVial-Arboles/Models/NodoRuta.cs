using RedVial_Arboles.Models;

namespace RedVial_Arboles.Models
{
    public class NodoRuta
    {
        public Interseccion Interseccion { get; set; }
        public NodoRuta Izquierda { get; set; }
        public NodoRuta Derecha { get; set; }

        public NodoRuta(Interseccion interseccion)
        {
            Interseccion = interseccion;
            Izquierda = null;
            Derecha = null;
        }
    }
}
