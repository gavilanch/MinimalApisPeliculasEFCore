using MinimalAPIPeliculas.Entidades;
using Error = MinimalAPIPeliculas.Entidades.Error;

namespace MinimalAPIPeliculas.Repositorios
{
    public interface IRepositorioErrores
    {
        Task Crear(Error error);
    }
}