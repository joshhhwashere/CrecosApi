using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrecosApi.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
        public List<PedidoDetalle> DetallesDePedido { get; set; }
    }
}
