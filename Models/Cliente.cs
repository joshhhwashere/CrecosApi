using System.ComponentModel.DataAnnotations;

namespace CrecosApi.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public bool Estado { get; set; }
        public List<Pedido> Pedidos { get; set; }

    }
}
