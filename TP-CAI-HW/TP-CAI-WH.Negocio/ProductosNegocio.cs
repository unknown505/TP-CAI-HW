using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_CAI_HW.Entidades;
using TP_CAI_HW.Entidades.Dominio;
using TP_CAI_HW.Datos;

namespace TP_CAI_HW.Negocio
{
    public class ProductosNegocio
    {
        private ProductosMapper _productosMapper;

        public ProductosNegocio()
        {
            _productosMapper = new ProductosMapper();
        }

        public List<Productos> TraerProductos()
        {
            return _productosMapper.GetProduct();
        }
        public void IngresarProducto(string nombre, int idCategoria, int idProveedor, double precio, int stock)
        {
            Productos p = new Productos(nombre, idCategoria, precio, stock, idProveedor);
            TransactionResult tr = _productosMapper.InsertProduct(p);
            if (!tr.IsOk)
            {
                throw new Exception($"El producto {nombre} falló al ser ingresado. Detalle: " + tr.Error);
            }
        }
    }
}