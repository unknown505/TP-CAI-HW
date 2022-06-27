using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_CAI_HW.Entidades;
using TP_CAI_HW.Entidades.Dominio;
using TP_CAI_HW.Entidades.Dominio.Exepciones_;
using Newtonsoft.Json;

namespace TP_CAI_HW.Datos
{
    public class ProveedoresMapper
    {
        private NameValueCollection ReverseMap(Proveedores proveedor)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("IdProducto", proveedor.IdProducto.ToString());
            n.Add("Nombre", proveedor.Nombre);
            n.Add("Apellido", proveedor.Apellido);
            n.Add("Email", proveedor.Email);
            n.Add("Cuit", proveedor.Cuit);
            n.Add("Activo", proveedor.Activo.ToString());
            n.Add("FechaAlta", proveedor.FechaAlta.ToString());
            //n.Add("FechaBaja", proveedor.FechaBaja.ToString());
            n.Add("Usuario", proveedor.Usuario.ToString());
            n.Add("IdProveedor", proveedor.IdProveedor.ToString());
            return n;
        }

        public Proveedores GetProvidXId(int IdProveedor)
        {
            string id = IdProveedor.ToString();
            string json = WebHelper.Get("VentaHardware/Proveedores" + id);
            Proveedores p = JsonConvert.DeserializeObject<Proveedores>(json);
            if (p.IdProducto == IdProveedor)
            {
                return p;
            }
            else
            {
                throw new EXCodigoNoEncontrado(IdProveedor);
            }

        }
        public List<Proveedores> GetProv()
        {
            string json = WebHelper.Get("VentaHardware/Proveedores");
            List<Proveedores> proveedor = JsonConvert.DeserializeObject<List<Proveedores>>(json);
            return proveedor;
        }

        public TransactionResult InsertProv(Proveedores p)
        {
            NameValueCollection obj = ReverseMap(p);
            string json = WebHelper.Post("VentaHardware/Proveedores", obj);
            TransactionResult rt = JsonConvert.DeserializeObject<TransactionResult>(json);
            return rt;
        }
    }
}
