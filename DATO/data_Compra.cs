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
    class data_Compra
    {
        static SqlConnection cn = new SqlConnection(clsConexion.cadConexion());

        public static DataTable listarComprasDA()
        {
            return SqlHelper.ExecuteDataTable(cn, "");
        }

        public static DataTable detalleComprasDA(int idcom)
        {
            return SqlHelper.ExecuteDataTable(cn, "", idcom);
        }

        public static DataSet 

    }
}
