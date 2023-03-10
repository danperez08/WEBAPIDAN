using System.ComponentModel.DataAnnotations;

namespace WEBAPIDAN.Entidades
{
    public class Modelo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del modelo es requerido")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //public List<Teclado> Teclados { get; set; }

        
        
}
}
