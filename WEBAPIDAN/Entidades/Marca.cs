using System.ComponentModel.DataAnnotations;

namespace WEBAPIDAN.Entidades
{
    public class Marca
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre de la marca es requerido")]
        public string NombreMarca { get; set; }
        public string Descripcion { get; set; }
      
       //public List<Teclado> Teclados { get; set; } 
       
    }
}
