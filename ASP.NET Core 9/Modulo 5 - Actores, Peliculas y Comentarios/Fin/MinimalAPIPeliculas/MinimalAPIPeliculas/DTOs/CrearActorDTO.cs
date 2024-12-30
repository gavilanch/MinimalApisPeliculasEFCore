namespace MinimalAPIPeliculas.DTOs
{
    public class CrearActorDTO
    {
        public string Nombre { get; set; } = null!;
        public DateTime FechaNacimiento { get; set; }
        public IFormFile? Foto { get; set; }
    }
}
