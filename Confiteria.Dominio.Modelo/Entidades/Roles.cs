﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Confiteria.Infraestructura.AccesoDatos;

public partial class Roles
{
    public int IdRol { get; set; }

    public string NombreRol { get; set; }

    public virtual ICollection<Usuarios> Usuarios { get; set; } = new List<Usuarios>();
}