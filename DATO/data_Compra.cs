using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTIDAD;
using Microsoft.ApplicationBlocks.Data;

namespace DATO
{
    public class data_Compra
    {
        static SqlConnection cn = new SqlConnection(clsConexion.cadConexion());

        public static DataTable listarComprasDA()
        {
            return SqlHelper.ExecuteDataTable(cn, "");
        }

        public static DataTable detalleComprasDA(int idcom)
        {
            return SqlHelper.ExecuteDataTable(cn, "usp_detallesCompras", idcom);
        }

        public static int registrarCabeCompraDA(compra objc)
        {
            return SqlHelper.ExecuteNonQuery(cn,"",objc.com_prov,objc.cod_tdoc,objc.com_doc,objc.com_des,objc.com_total);
        }

         public static int registrarDetaCompraDA(compra objc)
        {
            return SqlHelper.ExecuteNonQuery(cn,"",objc.cod_com,objc.cod_pro,objc.dcom_can,objc.dcom_puni,objc.dcom_precio,objc.dcom_desc);
        }

        

    }
}
