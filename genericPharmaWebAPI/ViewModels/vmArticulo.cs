﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using genericPharmaWebAPI.Models;
using genericPharmaWebAPI.ViewModels;
using AutoMapper;

namespace genericPharmaWebAPI.ViewModels
{
    public class vmArticulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public System.DateTime Vencimiento { get; set; }
        public int IdPaquete { get; set; }
        public int IdClasificacion { get; set; }
        public int IdProveedor { get; set; }
        public int PrecioCompra { get; set; }
        public int PrecioVenta { get; set; }
    }
}