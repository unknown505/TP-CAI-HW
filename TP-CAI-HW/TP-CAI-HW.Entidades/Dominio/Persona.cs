using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CAI_HW.Entidades
{
    abstract class Persona
    {
        protected string _id;
        protected string _nombre;
        protected string _apellido;
        protected string _direccion;
        protected long   _telefono;
        protected string _mail;

        public string ID { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public long Telefono { get => _telefono; set => _telefono = value; }
        public string Mail { get => _mail; set => _mail = value; }
    
        public Persona(string Nombre, string Apellido, string Direccion, long Telefono, string Mail)
        {
            _nombre = Nombre;
            _apellido = Apellido;
            _direccion = Direccion;
            _telefono = Telefono;
            _mail = Mail;
        }
    
    
    
    
    
    }

}
