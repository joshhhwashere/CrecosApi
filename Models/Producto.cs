using System.ComponentModel.DataAnnotations;

namespace CrecosApi.Models
{
    public class Producto
    {
            [Key]
            public int Id { get; set; }
            public string Nombre { get; set; }
            public List<PedidoDetalle> DetallesDePedido { get; set; }

            // Constructor
            public Producto()
            {
                Nombre = "NombrePredeterminado";
                DetallesDePedido = new List<PedidoDetalle>();
            }
    }
}
