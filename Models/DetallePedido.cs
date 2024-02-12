using System;
using System.Collections.Generic;

namespace MakiYumpuWorkers.Models;

public partial class DetallePedido
{
    public int IdPedido { get; set; }

    public int IdFichaTecnica { get; set; }

    public int CantidadPrenda { get; set; }

    public decimal PrecioUnitario { get; set; }

    public virtual FichaTecnica IdFichaTecnicaNavigation { get; set; } = null!;

    public virtual Pedido IdPedidoNavigation { get; set; } = null!;
}
