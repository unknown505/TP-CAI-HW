using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_CAI_HW.Entidades.Utilidades;
using System.Runtime.Serialization;

namespace TP_CAI_HW.Entidades
{
    [DataContract]
    public class Cliente : Persona
    {
        private int _idCliente;
        private int _dni;
        private DateTime _fechaNac;
        private DateTime _fechaAlta;
        private bool _actividad;
        private string _usuario;
        private string _host;       

        public int Dni { get => _dni; set => _dni = value; }
        public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public bool Activo { get => _actividad; set => _actividad = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Host { get => _host; set => _host = value; }
        [DataMember (Name = "id")]
        public int IdCliente { get => _idCliente; set => _idCliente = value; }

        public Cliente(string Nombre, string Apellido, string Direccion, string Telefono, string Email, int Dni, DateTime FechaNac) : base(Nombre, Apellido, Direccion, Telefono, Email)
        {
            _dni = Dni;
            _nombre = Nombre;
            _apellido = Apellido;
            _direccion = Direccion;
            _email = Email;
            _telefono = Telefono;
            _fechaNac = FechaNac;
            _fechaAlta = DateTime.Now;
            _actividad = true;
            _usuario = Users.User1.ToString();
            //_idCliente = IdCliente;
        }

        public string ClienteCompleto
        {
            get { return "ID:"+IdCliente + " - " + Apellido + ", " + Nombre ; }
        }
    }
}
