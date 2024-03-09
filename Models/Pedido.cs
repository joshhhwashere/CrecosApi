using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrecosApi.Models
{
    public class Pedido
    {
                [Key]
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<PedidoDetalle> DetallesDePedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public string Estado { get; set; }

        // Constructor
        public Pedido()
        {
            Cliente = new Cliente();
            DetallesDePedido = new List<PedidoDetalle>();
            Estado = "EstadoPredeterminado";
        }
    }
}
