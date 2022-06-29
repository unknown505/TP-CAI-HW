using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_CAI_HW.Entidades;
using TP_CAI_HW.Entidades.Dominio;
using TP_CAI_HW.Datos;

namespace TP_CAI_HW.Negocio
{
    public class ClientesNegocio
    {
        private ClientesMapper _clientesMapper;

        public ClientesNegocio()
        {
            _clientesMapper = new ClientesMapper();
        }
        public void IngresarCliente(string nombre, string apellido, string direccion, string telefono, string mail, int dni, DateTime fechaNacimiento)
        {
            Cliente c = new Cliente(nombre, apellido, direccion, telefono, mail, dni, fechaNacimiento);
            TransactionResult tr = _clientesMapper.InsertCliente(c);
            if (!tr.IsOk)
            {
                throw new Exception($"El cliente {nombre} falló al ser ingresado. Detalle: " + tr.Error);
            }
        }
    }
}
