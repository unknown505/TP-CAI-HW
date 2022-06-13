using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Configuration;

namespace TP_CAI_HW.Entidades
{
    class Ventas
    {
        private string _idVenta;
        private string _idCliente;
        private string _idProducto;
        private int _cantidad;
        private DateTime _fechaAlta;

        public string IdVenta { get => _idVenta; set => _idVenta = value; }
        public string IdCliente { get => _idCliente; set => _idCliente = value; }
        public string IdProducto { get => _idProducto; set => _idProducto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        public Ventas(string IdVenta, string IdCliente, string IdProducto, int Cantidad)
        {
            //_idVenta;
            //_idCliente;
            //_idProducto;
            //_cantidad
            //_fechaAlta = DateTime.Now("dd/MM/yyyy");
        }
    }
}
