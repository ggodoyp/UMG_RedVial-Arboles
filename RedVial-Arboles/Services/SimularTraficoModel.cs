using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RedVial_Arboles.Services
{
    public class SimularTraficoModel : PageModel
    {
        // Ya no necesitamos inyectar el servicio aquí si lo hacemos en la vista .razor
        public void OnGet()
        {
            // Lógica para cuando la página se carga inicialmente (si es necesario)
        }
    }
}
