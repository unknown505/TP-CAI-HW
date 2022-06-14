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
    public class VentasMapper
    {
        private NameValueCollection ReverseMap(Ventas venta)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("IdCliente", venta.IdCliente.ToString());
            n.Add("IdProducto", venta.IdProducto.ToString());
            n.Add("Cantidad", venta.Cantidad.ToString());
            n.Add("Estad", venta.Estado.ToString());
            n.Add("FechaAlta", venta.FechaAlta.ToString());
            n.Add("FechaAlta", venta.FechaAlta.ToString());
            n.Add("Usuario", venta.Usuario.ToString());
            n.Add("IdVenta", venta.IdVenta.ToString());


            return n;
        }

        public Ventas GetSellXId(int IdVenta)
        {
            string id = IdVenta.ToString();
            string json = WebHelper.Get("VentaHardware/Ventas" + id);
            Ventas p = JsonConvert.DeserializeObject<Ventas>(json);
            if (p.IdProducto == IdVenta)
            {
                return p;
            }
            else
            {
                throw new EXCodigoNoEncontrado(IdVenta);
            }

        }
        public List<Ventas> GetSell()
        {
            string json = WebHelper.Get("VentaHardware/Ventas");
            List<Ventas> venta = JsonConvert.DeserializeObject<List<Ventas>>(json);
            return venta;
        }

        public TransactionResult InsertSell(Ventas p)
        {
            NameValueCollection obj = ReverseMap(p);
            string json = WebHelper.Post("VentaHardware/Ventas", obj);
            TransactionResult rt = JsonConvert.DeserializeObject<TransactionResult>(json);
            return rt;
        }
    }
}
