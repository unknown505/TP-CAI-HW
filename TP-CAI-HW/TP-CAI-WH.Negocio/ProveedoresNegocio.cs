using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_CAI_HW.Datos;
using TP_CAI_HW.Entidades;

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
    }
}