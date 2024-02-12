using System;
using System.Collections.Generic;

namespace MakiYumpuWorkers.Models;

public partial class DetalleFt
{
    public int IdFichaTecnica { get; set; }

    public int IdMaterial { get; set; }

    public virtual FichaTecnica IdFichaTecnicaNavigation { get; set; } = null!;

    public virtual Material IdMaterialNavigation { get; set; } = null!;
}
