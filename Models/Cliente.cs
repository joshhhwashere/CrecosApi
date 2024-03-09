using System.ComponentModel.DataAnnotations;

namespace CrecosApi.Models
{
    public class Cliente
    {
                [Key]
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public List<Pedido> Pedidos { get; set; }

        // Constructor
        public Cliente()
        {
            PrimerNombre = "NombrePredeterminado";
            PrimerApellido = "ApellidoPredeterminado";
            Pedidos = new List<Pedido>();  // Lista vacía por defecto

        }
    }   
}
