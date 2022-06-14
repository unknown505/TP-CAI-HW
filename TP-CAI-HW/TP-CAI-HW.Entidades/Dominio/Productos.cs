﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Configuration;

namespace TP_CAI_HW.Entidades
{
    public class Productos
    {
        private int _idProducto;
        private int _idCategoria;
        private string _nombre;
        private DateTime _fechaAlta;
        private double _precio;
        private int _stock;
        private int _idProveedor;
        private int _usuario;

        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public int IdProveedor { get => _idProveedor; set => _idProveedor = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public int Usuario { get => _usuario; set => _usuario = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }



        public Productos(int IdProducto, int IdCategoria, string Nombre, DateTime FechaAlta,  double Precio, int Stock, int IdProveedor, int Usuario)
        {
            _idCategoria = IdCategoria;
            _nombre = Nombre;
            _fechaAlta = FechaAlta;
            _precio = Precio;
            _stock = Stock;
            _idProveedor = IdProveedor;
            _usuario = Usuario;
            _idProducto = IdProducto;

        }
    }
}