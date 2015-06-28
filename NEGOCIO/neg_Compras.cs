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
    public class neg_Compras
    {

        public static DataTable listarComprasNE()
        {
            return data_Compra.listarComprasDA();
        }

        public static DataTable detalleComprasNE(int idcom)
        {
            return data_Compra.detalleComprasDA(idcom);
        }

        public static int registrarCabeCompraNE(compra objc)
        {
            return data_Compra.registrarCabeCompraDA(objc);
        }

        public static int registrarDetaCompraNE(compra objc)
        {
            return data_Compra.registrarDetaCompraDA(objc);
        }
    }
}
