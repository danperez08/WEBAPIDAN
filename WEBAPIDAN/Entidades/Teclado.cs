using System.ComponentModel.DataAnnotations;

namespace WEBAPIDAN.Entidades
{
    public class Teclado
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El precio es requerido")]
        public int Precio { get; set; }
        [Required(ErrorMessage = "El Tipo de conexion es requerido")]
        public string TipoConexion { get; set; }
        public string Color { get; set; }
        /* public int ModeloId { get; set; }
         public Modelo Modelo { get; set; }
         public int MarcaId { get; set; }//fks
         public Marca Marca { get; set; }*/
        public List<Modelo> Modelos { get; set; }
        public List<Marca> Marcas { get; set; }



    }
}
