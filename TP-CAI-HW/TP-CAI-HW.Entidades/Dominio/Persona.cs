using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CAI_HW.Entidades
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected string _direccion;
        protected string _telefono;
        protected string _email;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
    
        public Persona(string Nombre, string Apellido, string Direccion, string Telefono, string Email)
        {
            _nombre = Nombre;
            _apellido = Apellido;
            _direccion = Direccion;
            _telefono = Telefono;
            _email = Email;
        }
    
    
    
    
    
    }

}
