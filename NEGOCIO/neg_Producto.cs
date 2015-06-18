using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DATO;
using ENTIDAD;

namespace NEGOCIO
{
    public class neg_Producto
    {
        public static DataTable listaProductosNE()
        {
            return data_Producto.listaProductosDA();
        }

        public static DataTable detalleProductoNE(producto objPro)
        {
            return data_Producto.detalleProductoDA(objPro);
        }

        public static DataTable listaProductoxCategoriaNE(int codcate)
        {
            return data_Producto.listaProductoxCategoriaDA(codcate);
        }

        public static int agregarProductoNE(producto objPro)
        {
            return data_Producto.agregarProductoDA(objPro);
        }

        public static int editarProductoNE(producto objPro)
        {
            return data_Producto.editarProductoDA(objPro);
        }

        public static int eliminarProductoNE(producto objPro)
        {
            return data_Producto.editarProductoDA(objPro);
        }

        public static DataSet productoxcategoriaNE()
        {
            return data_Producto.productoxcategoriaDA();
        }


        public static DataTable listaMarcasProductoNE()
        {
            return data_Producto.listaMarcasProductoDA();
        }
    }
}
