﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public String Documento { get; set; }
        public String NombreCompleto { get; set; }
        public String Correo { get; set; }
        public String Telefono { get; set; }
        public bool Estado { get; set; }
        public int FechaDeCreacion { get; set; }


    }
}
