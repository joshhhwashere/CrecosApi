using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrecosApi.Models
{
    public class PedidoDetalle
    {
        [Key]
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public string Nombre { get; set; }

        // Constructor
        public PedidoDetalle()
        {
            Pedido = new Pedido();
            Producto = new Producto();
            Nombre = "NombrePredeterminado";
        }
    }
}
