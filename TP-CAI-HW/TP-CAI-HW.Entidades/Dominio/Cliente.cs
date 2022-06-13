using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Configuration;

namespace TP_CAI_HW.Entidades
{
    class Cliente : Persona
    {
        private string _idCliente;
        private string _fechaAlta; //modificar a datetime
        private bool _cliActivo;


        public string IdCliente { get => _idCliente; set => _idCliente = value; }
        public string FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public bool Activo { get => _cliActivo; set => _cliActivo = value; }

        public Cliente(string Nombre, string Apellido, string Direccion, long Telefono, string Mail) : base(Nombre, Apellido, Direccion, Telefono, Mail)
        {
            //_idCliente
            //_fechaAlta = DateTime.Now("dd/MM/yyyy");
            _cliActivo = true;
            
        }
    }
}
