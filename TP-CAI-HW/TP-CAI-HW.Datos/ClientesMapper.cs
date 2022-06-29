using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_CAI_HW.Entidades;
using TP_CAI_HW.Entidades.Dominio;
using Newtonsoft.Json;

namespace TP_CAI_HW.Datos
{
    public class ClientesMapper
    {
        private NameValueCollection ReverseMap (Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("DNI", cliente.Dni.ToString());
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);
            n.Add("Email", cliente.Email);
            n.Add("Telefono", cliente.Telefono);
            n.Add("FechaNacimiento", cliente.FechaNac.ToString("yyyy-MM-dd"));
            n.Add("FechaAlta", cliente.FechaAlta.ToString("yyyy-MM-dd"));
            n.Add("Activo", cliente.Activo.ToString());
            n.Add("Usuario", cliente.Usuario.ToString());
            n.Add("Host", cliente.Host);
            n.Add("id", cliente.IdCliente.ToString());

            return n;
        }

        public List<Cliente> GetDatos()
        {
            string json2 = WebHelper.Get("cliente");
            List<Cliente> resultado = lista(json2);
            return resultado;
        }

        private List<Cliente> lista(string json)
        {
            List<Cliente> lista = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lista;
        }

        public TransactionResult InsertCliente(Cliente c)
        {
            NameValueCollection obj = ReverseMap(c);
            string json = WebHelper.Post("cliente", obj);
            TransactionResult lista = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lista;
        }

    }
}
