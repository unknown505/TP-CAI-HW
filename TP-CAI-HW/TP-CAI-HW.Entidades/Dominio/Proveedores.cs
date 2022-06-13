using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Configuration;

namespace TP_CAI_HW.Entidades
{
    public class Proveedores
    {
        private int _idProducto;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _cuit;
        private bool _actividad;
        private DateTime _fechaAlta;
        private DateTime _fechaBaja;
        private int _usuario;
        private string _idProveedor;

        //private string _nombre;

        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public string Cuit { get => _cuit; set => _cuit = value; }
        public bool Activo { get => _actividad; set => _actividad = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }
        public int Usuario { get => _usuario; set => _usuario = value; }
        public string IdProveedor { get => _idProveedor; set => _idProveedor = value; }



        public Proveedores(int IdProveedor, int IdProducto)
        {
            //_idProveedor;
            //_idProducto;
            //_fechaAlta = DateTime.Now("dd/MM/yyyy");           
        }
    }
}
