namespace WEBAPIDAN.Entidades
{
    public class Teclado
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public string TipoConexion { get; set; }
        public string Color { get; set; }
        public int ModeloId { get; set; }
        public Modelo Modelo { get; set; }
       //public int MarcaId { get; set; }//fks
       // public Marca Marca { get; set; }
       


    }
}
