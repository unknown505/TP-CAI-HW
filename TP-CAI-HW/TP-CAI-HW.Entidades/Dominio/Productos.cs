using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CAI_HW.Entidades
{
    public class Productos
    {
        private string _idProducto;
        private string _idCategoria;
        private string _nombre;
        private DateTime _fechaAlta;
        private double _precio;
        private int _stock;
        
        public string IdProducto { get => _idProducto; set => _idProducto = value; }
        public string IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }

        public Productos(string IdProveedor, string IdProducto, string Nombre, double Precio, int Stock)
        {
            //_idProducto;
            //_idCategoria;
            //_fechaAlta = DateTime.Now("dd/MM/yyyy");
        }
    }
}
