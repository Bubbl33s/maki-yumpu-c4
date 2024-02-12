using System;
using System.Collections.Generic;

namespace MakiYumpuWorkers.Models;

public partial class FormPedido
{
    public int IdFormPedido { get; set; }

    public string NombreCompletoCliente { get; set; } = null!;

    public string? CorreoCliente { get; set; }

    public string? PaisCliente { get; set; }

    public DateTime Fecha { get; set; }
}
