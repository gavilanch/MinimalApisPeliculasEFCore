namespace MinimalAPIPeliculas.Entidades
{
    public class ActorPelicula
    {
        public int ActorId { get; set; }
        public Actor Actor { get; set; } = null!;
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; } = null!;
        public int Orden { get; set; }
        public string Personaje { get; set; } = null!;
    }
}
