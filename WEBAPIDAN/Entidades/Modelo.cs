namespace WEBAPIDAN.Entidades
{
    public class Modelo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public List<Teclado> Teclados { get; set; }

        //public int TecladoId { get; set; }
        //public Teclado Teclado { get; set; }
        
}
}
