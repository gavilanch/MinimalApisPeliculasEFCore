namespace MinimalAPIPeliculas.DTOs
{
    public class ComentarioDTO
    {
        public int Id { get; set; }
        public string Cuerpo { get; set; } = null!;
        public int PeliculaId { get; set; }
    }
}
