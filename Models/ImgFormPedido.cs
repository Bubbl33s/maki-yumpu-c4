using System;
using System.Collections.Generic;

namespace MakiYumpuWorkers.Models;

public partial class ImgFormPedido
{
    public int IdFormPedido { get; set; }

    public string RutaImagen { get; set; } = null!;

    public virtual FormPedido IdFormPedidoNavigation { get; set; } = null!;
}
