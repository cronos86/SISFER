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
    public class data_Categoria
    {
        static SqlConnection cn = new SqlConnection(clsConexion.cadConexion());

        public static DataTable listaCategoriasDA()
        {
            return SqlHelper.ExecuteDataTable(cn,CommandType.Text, "select * from Categoria");
        }
    }
}
