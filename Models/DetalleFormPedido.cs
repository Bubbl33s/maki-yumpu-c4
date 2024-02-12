using System;
using System.Collections.Generic;

namespace MakiYumpuWorkers.Models;

public partial class DetalleFormPedido
{
    public int IdFormPedido { get; set; }

    public string DescPrenda { get; set; } = null!;

    public string DetallesPrenda { get; set; } = null!;

    public int CantidadPrenda { get; set; }

    public virtual FormPedido IdFormPedidoNavigation { get; set; } = null!;
}
