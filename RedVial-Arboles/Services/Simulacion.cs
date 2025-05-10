using Microsoft.AspNetCore.Mvc;
using RedVial_Arboles.Data;
using RedVial_Arboles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;

namespace RedVial_Arboles.Services
{
    public class Simulacion
    {
        private readonly HttpClient _httpClient;

        public Simulacion(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

   
    public string mensaje { get; set; } = string.Empty; // Log para debuguear.
        public async Task<List<Interseccion>> SimularFlujoVehicular()
        {
            List<Interseccion>?  lstInter = new List<Interseccion>();
            //mensaje = $"Ingresa metodo";
            try
            {              
                lstInter = await _httpClient.GetFromJsonAsync<List<Interseccion>>("api/Intersecciones/congestionadas");                
            }
            catch (Exception ex)
            {

                mensaje= $"Error: {ex}";
            }
            return lstInter;
            
        }

        public async Task<List<Interseccion>> IdentificarCongestion()
        {
            try
            {
                List<Interseccion> lstInter = new List<Interseccion>();
                lstInter = await _httpClient.GetFromJsonAsync<List<Interseccion>>("api/Intersecciones/congestionadas");
                return lstInter;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }

            return null;
            
        }

        public int CalcularTiempoRecorrido(int interseccionOrigenId, int interseccionDestinoId)
        {
            return 0;
        }

        public List<Via> AnalizarCuellosBotella()
        {
            return new List<Via>();
        }
    }
}
