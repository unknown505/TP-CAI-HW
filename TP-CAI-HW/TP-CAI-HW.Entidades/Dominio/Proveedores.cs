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
    public class Proveedores
    {
        
        private int _idProducto;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _cuit;
        private bool _activo;
        private DateTime _fechaAlta;
        private DateTime? _fechaBaja;
        private int _usuario;
        private int _idProveedor;
        private string _direccion;

        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public string Cuit { get => _cuit; set => _cuit = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }
        public int Usuario { get => _usuario; set => _usuario = value; }
        [DataMember (Name = "id")]
        public int IdProveedor { get => _idProveedor; set => _idProveedor = value; }
        public string Direccion { get => _direccion; set => _direccion= value; }


        public Proveedores(string Nombre, string Apellido, string Direccion, string Cuit, int IdProducto, DateTime? FechaBaja)
        {            
            _nombre = Nombre;
            _apellido = Apellido;
            _direccion = Direccion;
            _cuit = Cuit;
            _idProducto = IdProducto;
            _activo = true;
            _fechaAlta = DateTime.Now;
            _fechaBaja = FechaBaja;
            _usuario = Users.User2;
        }

        public string ProveedorCompleto
        {
            get { return "ID:" + IdProveedor.ToString() + " - " + Apellido + ", " + Nombre; }
        }
    }
}