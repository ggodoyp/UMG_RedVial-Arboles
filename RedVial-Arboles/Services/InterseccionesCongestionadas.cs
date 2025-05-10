using RedVial_Arboles.Models;

namespace RedVial_Arboles.Services
{
    public class InterseccionesCongestionadas
    {
        private readonly Simulacion _simulacionService;

        public InterseccionesCongestionadas(Simulacion simulacionService)
        {
            _simulacionService = simulacionService;
        }

        public List<Interseccion> InterseccionCongestionadas { get; set; }

        public async void OnGet()
        {
            InterseccionCongestionadas = await _simulacionService.IdentificarCongestion();
        }
    }
}
