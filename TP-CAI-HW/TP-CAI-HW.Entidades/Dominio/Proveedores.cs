using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CAI_HW.Entidades
{
    class Proveedores
    {
        private string _idProveedor;
        private string _idProducto;
        private DateTime _fechaAlta;
        private DateTime _fechaBaja;

        public string IdProveedor { get => _idProveedor; set => _idProveedor = value; }
        public string IdProducto { get => _idProducto; set => _idProducto = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }

        public Proveedores(int IdProveedor, int IdProducto)
        {
            //_idProveedor;
            //_idProducto;
            //_fechaAlta = DateTime.Now("dd/MM/yyyy");           
        }
    }
}
