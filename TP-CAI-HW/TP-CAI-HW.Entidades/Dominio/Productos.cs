using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Configuration;
using TP_CAI_HW.Entidades.Utilidades;

namespace TP_CAI_HW.Entidades
{
    [DataContract]
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
        [DataMember (Name = "id")]
        public int IdProducto { get => _idProducto; set => _idProducto = value; }



        public Productos(string Nombre, int IdCategoria, double Precio, int Stock, int IdProveedor)
        {
            _nombre = Nombre;
            _idCategoria = IdCategoria;
            _precio = Precio;
            _stock = Stock;
            _idProveedor = IdProveedor;
            _usuario = Users.User1;
            //_idProducto = _idProducto;
            _fechaAlta = DateTime.Now;

        }

        public string ProductoCompleto
        {
            get { return "ID:" + IdProducto + " - " + Nombre; }
        }
    }
}