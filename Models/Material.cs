﻿using System;
using System.Collections.Generic;

namespace MakiYumpuWorkers.Models;

public partial class Material
{
    public int IdMaterial { get; set; }

    public string IdMaterialBase { get; set; } = null!;

    public string IdPantone { get; set; } = null!;

    public string Hebras { get; set; } = null!;

    public virtual ICollection<DetalleOc> DetalleOcs { get; set; } = new List<DetalleOc>();

    public virtual MaterialBase IdMaterialBaseNavigation { get; set; } = null!;
}
