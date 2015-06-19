using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using ENTIDAD;

namespace DATO
{
    public class data_Venta
    {
        static SqlConnection cn = new SqlConnection(clsConexion.cadConexion());

        public static DataTable listaVentasDA()
        {
            return SqlHelper.ExecuteDataTable(cn, "usp_listarVentas");
        }

        public static DataTable detalleVentaDA(int idven)
        {
            return SqlHelper.ExecuteDataTable(cn, "usp_productosxVenta", idven);
        }

        public static DataTable codigoVenta()
        {
            return SqlHelper.ExecuteDataTable(cn,CommandType.Text,"select max(cod_ven) from Ventas");
        }

        public static int registrarCabeVentaDA(venta objv)
        {
            return SqlHelper.ExecuteNonQuery(cn, "usp_agregarCabeceraVenta", objv.ven_cli, objv.cod_tdoc, objv.ven_ndoc, objv.ven_total);
        }

        public static int registratDetaVentaDA(venta objv)
        {
            return SqlHelper.ExecuteNonQuery(cn, "usp_agregarDetalleVenta", objv.cod_ven, objv.cod_pro, objv.dven_can, objv.dven_puni, objv.dven_precio, objv.dven_desc);
        }
    }
}
