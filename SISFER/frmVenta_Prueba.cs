using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NEGOCIO;
using ENTIDAD;

namespace SISFER
{
    public partial class frmVenta_Prueba : Form
    {
        public frmVenta_Prueba()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        DataTable table = new DataTable();

        private void frmVenta_Prueba_Load(object sender, EventArgs e)
        {
            limpiarFrmVenta();
           // txtdesc.Enabled = false;
            txtcod.Text = (Convert.ToInt16(neg_Venta.codigoVentaNE().Rows[0][0].ToString()) + 1).ToString();
            listaCategoria();

            
            //table.Columns.Add("ID VENTA", typeof(int));
            table.Columns.Add("PRODUCTO", typeof(string));
            table.Columns.Add("CANTIDAD", typeof(int));
            table.Columns.Add("PRECIO_UNI", typeof(double));
            table.Columns.Add("PRECIO", typeof(double));
            table.Columns.Add("DSCTO", typeof(double));

            gridControl2.DataSource = neg_Venta.listaVentasNE();
        }

        void listaCategoria()
        {
            DataTable tblcate = neg_Categoria.listaCategoriasNE();
            for (int i = 0; i < tblcate.Rows.Count; i++)
            {
                cboCate.Properties.Items.Add(tblcate.Rows[i][1].ToString());
            }

            cmbcate.DisplayMember = "cat_des";
            cmbcate.ValueMember = "cod_cat";
            cmbcate.DataSource = tblcate;
            
            
        }
        
        void listaProductoxCategoria()
        {
            int codcate = Convert.ToInt16(cmbcate.SelectedValue);
            DataTable tblprod = neg_Producto.listaProductoxCategoriaNE(codcate);
            /*
            for (int i = 0; i < tblprod.Rows.Count; i++)
            {
                cboProd.Properties.Items.Add(tblprod.Rows[i][1].ToString());
            }*/
            cmbProd.DisplayMember = "pro_nom";
            cmbProd.ValueMember = "cod_pro";
            cmbProd.DataSource = neg_Producto.listaProductoxCategoriaNE(codcate);
            

           
        }

        private void cboCate_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            GetTable();
            gridControl1.DataSource = table;

            cboCate.SelectedIndex = 0;
            txtcan.Text = "";
            txtpuni.Text = "";
            txtdesc.Enabled = false;
            txtdesc.Text = "";
            chkdscto.Checked = false;
           

        }

        int cant;

    public DataTable GetTable()
    {
        //DataRow dr = table.Rows[0];
        string idprod= cmbProd.SelectedValue.ToString();

        
        foreach (DataRow item in table.Rows)
        {
            cant = (int)item["CANTIDAD"];
            if (item["PRODUCTO"] == idprod)
            {
                DialogResult resp= MessageBox.Show("Desea Actualizar la Cantidad???", "Producto Registrado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resp==DialogResult.OK)
                {                    
                       //DataRow[] fila=  table.Select("PRODUCTO = " + idprod);
                    item.Delete();
                    cant = Convert.ToInt16(txtcan.Text);
                    item["CANTIDAD"] = cant;
                    table.Rows.Add(cmbProd.SelectedValue.ToString(), cant,
                 Convert.ToDouble(txtpuni.Text), Convert.ToDouble(txtpuni.Text) * Convert.ToInt32(txtcan.Text), 0);
                    return table;
                }else
                {
                    
                    
                    //item.Delete();
                    break;
                }                
            }                    
        }

        table.Rows.Add(cmbProd.SelectedValue.ToString(), cant,
       Convert.ToDouble(txtpuni.Text), Convert.ToDouble(txtpuni.Text) * Convert.ToInt32(txtcan.Text), 0);
        

       

     

        txttotal.Text = "S/. " + table.Compute("SUM(PRECIO)", "").ToString() + ".00";
	return table;
    }



        private void cmbcate_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProd.SelectedIndex = -1;
            txtcodcate.Text = cmbcate.SelectedValue.ToString();
            listaProductoxCategoria();
        }

        private void chkdscto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkdscto.Checked==true)
            {
                txtdesc.Enabled = true;
            }
            else
            {
                txtdesc.Text = "";
                txtdesc.Enabled = false;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtdato.Text = gridView1.GetSelectedRows().FirstOrDefault().ToString();
            //gridView1.FocusedRowHandle.ToString();
        }

        private void repositoryItemHyperLinkEdit1_Click(object sender, EventArgs e)
        {
            table.Rows[gridView1.GetSelectedRows().FirstOrDefault()].Delete();
            txttotal.Text = "S/. " + table.Compute("SUM(PRECIO)", "").ToString() + ".00";
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int resp;

            venta objv = new venta();
            objv.cod_ven = Convert.ToInt16(txtcod.Text);
            objv.ven_cli = txtcli.Text;
            objv.ven_fec = Convert.ToDateTime(txtfec.Text);
            objv.cod_tdoc = 2;
            objv.ven_ndoc = txtndoc.Text;
            objv.ven_total = Convert.ToDouble(table.Compute("SUM(PRECIO)", "").ToString());

            resp=neg_Venta.registrarCabeVentaNE(objv);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                objv.cod_ven = Convert.ToInt16(txtcod.Text);
                objv.cod_pro=table.Rows[i][0].ToString();
                objv.dven_can = Convert.ToInt16(table.Rows[i][1].ToString());
                objv.dven_puni = Convert.ToDouble(table.Rows[i][2].ToString());
                objv.dven_precio = Convert.ToDouble(table.Rows[i][3].ToString());
                objv.dven_desc = Convert.ToDouble(table.Rows[i][4].ToString());
                resp = neg_Venta.registratDetaVentaNE(objv);
            }

            gridControl2.DataSource = neg_Venta.listaVentasNE();
            limpiarFrmVenta();
        }

        void limpiarFrmVenta()
        {
            txtcli.Text = "";
            txtndoc.Text = "";
            //txtfec.Text = DateTime.Now.ToString();
            txttotal.Text = "";
            chkdscto.Checked = false;
            txtdesc.Text = "";
            txtdesc.Enabled = false;

            cboCate.SelectedIndex = 0;
            txtcan.Text = "";
            txtpuni.Text = "";
            
        }

    }
}
