using Microsoft.AspNetCore.Identity;

namespace MinimalAPIPeliculas.Servicios
{
    public interface IServicioUsuarios
    {
        Task<IdentityUser?> ObtenerUsuario();
    }
}