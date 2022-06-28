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
    public class ProductosMapper
    {
        private NameValueCollection ReverseMap(Productos producto)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("IdCategoria", producto.IdCategoria.ToString());
            n.Add("Nombre", producto.Nombre);
            n.Add("Stock", producto.Stock.ToString());
            n.Add("IdProveedor", producto.IdProveedor.ToString());
            n.Add("Precio", producto.Precio.ToString());
            n.Add("FechaAlta", producto.FechaAlta.ToString());
            //n.Add("Usuario", producto.Usuario.ToString());
            n.Add("IdProducto", producto.IdProducto.ToString());
            return n;
        }

        public Productos GetProductXId(int IdProducto)
        {
            string id = IdProducto.ToString();
            string json = WebHelper.Get("VentaHardware/Productos" + id);
            Productos p = JsonConvert.DeserializeObject<Productos>(json);
            if (p.IdProducto == IdProducto)
            {
                return p;
            }
            else
            {

                throw new EXCodigoNoEncontrado(IdProducto);
            }

        }
        public List<Productos> GetProduct()
        {
            string json = WebHelper.Get("VentaHardware/Productos");
            List<Productos> productos = JsonConvert.DeserializeObject<List<Productos>>(json);
            return productos;
        }

        public TransactionResult InsertProduct(Productos p)
        {
            NameValueCollection obj = ReverseMap(p);
            string json = WebHelper.Post("VentaHardware/Productos", obj);
            TransactionResult rt = JsonConvert.DeserializeObject<TransactionResult>(json);
            return rt;
        }
    }
}