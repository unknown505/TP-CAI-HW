using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_CAI_HW.Datos;
using TP_CAI_HW.Entidades;
using TP_CAI_HW.Entidades.Dominio;

namespace TP_CAI_HW.Negocio
{
    public class ProveedoresNegocio
    {
        private ProveedoresMapper _proveedoresMapper;

        public ProveedoresNegocio()
        {
            _proveedoresMapper = new ProveedoresMapper();
        }

        public List<Proveedores> TraerProveedores()
        {
            return _proveedoresMapper.GetProv();
        }

        public void IngresarProveedor(string nombre, string apellido, string direccion, string cuit, int idProducto)
        {
            Proveedores p = new Proveedores(nombre, apellido, direccion, cuit, idProducto, null);
            TransactionResult tr = _proveedoresMapper.InsertProv(p);
            if (!tr.IsOk)
            {
                throw new Exception($"El proveedor {nombre} falló al ser ingresado. Detalle: " + tr.Error);
            }
        }
    }
}