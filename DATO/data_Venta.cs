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
            return SqlHelper.ExecuteDataTable(cn, "");
        }

        public static DataTable detalleVentaDA(int idven)
        {
            return SqlHelper.ExecuteDataTable(cn, "", idven);
        }

        public static DataTable codigoVenta()
        {
            return SqlHelper.ExecuteDataTable(cn,CommandType.Text,"select max(cod_ven) from Ventas");
        }
    }
}
