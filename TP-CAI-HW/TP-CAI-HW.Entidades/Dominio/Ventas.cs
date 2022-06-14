using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CAI_HW.Entidades
{
    public class Ventas
    {

        private int _idCliente;
        private int _idProducto;
        private int _cantidad;
        private int _estado;
        private DateTime _fechaAlta;
        private int _usuario;
        private int _idVenta;

        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public int Estado { get => _estado; set => _estado = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public int Usuario { get => _usuario; set => _usuario = value; }
        public int IdVenta { get => _idVenta; set => _idVenta = value; }


        public Ventas(int IdCliente, int IdProducto, int Cantidad, int Estado, DateTime FechaAlta, int Usuario, int IdVenta)
        {
            _idCliente = IdCliente;
            _idProducto = IdProducto;
            _cantidad = Cantidad;
            _estado = Estado;
            _fechaAlta = FechaAlta;
            _usuario = Usuario;
            _idVenta = IdVenta;
        }
    }
}
