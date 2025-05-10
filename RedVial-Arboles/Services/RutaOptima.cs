using RedVial_Arboles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedVial_Arboles.Services
{
    public class RutaOptima
    {
        public async Task<List<Interseccion>> EncontrarRutaOptimaLineal(
             List<Interseccion> intersecciones,
             int interseccionOrigenId,
             int interseccionDestinoId)
        {
            var origen = intersecciones.FirstOrDefault(i => i.idInterseccion == interseccionOrigenId);
            var destino = intersecciones.FirstOrDefault(i => i.idInterseccion == interseccionDestinoId);

            if (origen == null || destino == null)
            {
                return null;
            }

            //Utilizar una cola para la busqueda
            Queue<List<Interseccion>> cola = new Queue<List<Interseccion>>();
            cola.Enqueue(new List<Interseccion> { origen });

            //Utilizar un hashset para evitar ciclos
            HashSet<int> nodosVisitados = new HashSet<int>();
            nodosVisitados.Add(origen.idInterseccion);

            List<Interseccion> rutaOptima = null;
            int minVehiculosEspera = int.MaxValue;

            while (cola.Count > 0)
            {
                List<Interseccion> rutaActual = cola.Dequeue();
                Interseccion ultimoNodo = rutaActual.Last();

                if (ultimoNodo == destino)
                {
                    // Calcular el total de vehiculos en espera de la ruta
                    int totalVehiculosEspera = rutaActual.Sum(i => i.cantidadVehiculosEspera);
                    if (totalVehiculosEspera < minVehiculosEspera)
                    {
                        minVehiculosEspera = totalVehiculosEspera;
                        rutaOptima = rutaActual;
                    }
                    continue; //Continuar buscando por si existe una ruta mejor
                }

                //Obtener las intersecciones adyacentes
                List<Interseccion> adyacentes = ObtenerInterseccionesAdyacentes(intersecciones, ultimoNodo);

                //Agregar los adyacentes a la cola
                foreach (var adyacente in adyacentes)
                {
                    if (!nodosVisitados.Contains(adyacente.idInterseccion))
                    {
                        //Crea una nueva lista de ruta
                        List<Interseccion> nuevaRuta = new List<Interseccion>(rutaActual);
                        nuevaRuta.Add(adyacente);
                        cola.Enqueue(nuevaRuta);

                        //Marcar el nodo como visitado
                        nodosVisitados.Add(adyacente.idInterseccion);
                    }
                }
            }
            return rutaOptima;
        }

        private List<Interseccion> ObtenerInterseccionesAdyacentes(
            List<Interseccion> intersecciones,
            Interseccion nodoActual)
        {
            // Implementa tu lógica para determinar las intersecciones adyacentes
            // Devuelve una lista de Interseccion que son adyacentes al nodoActual
            // (basado en tu modelo de datos y la conexión entre intersecciones)
            // Esta es una implementación temporal
            return intersecciones.Where(i => i.idInterseccion != nodoActual.idInterseccion).ToList();
        }
    }
}
