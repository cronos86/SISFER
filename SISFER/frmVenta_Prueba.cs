using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
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
            txtdesc.Enabled = false;
            txtcod.Text = (Convert.ToInt16(neg_Venta.codigoVentaNE().Rows[0][0].ToString()) + 1).ToString();
            listaCategoria();

            
            //table.Columns.Add("ID VENTA", typeof(int));
            table.Columns.Add("PRODUCTO", typeof(string));
            table.Columns.Add("CANTIDAD", typeof(int));
            table.Columns.Add("PRECIO_UNI", typeof(double));
            table.Columns.Add("PRECIO", typeof(double));
            table.Columns.Add("DSCTO", typeof(double));

         
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

            
           

        }

    public DataTable GetTable()
    {
        //DataRow dr = table.Rows[0];
        string idprod= cmbProd.SelectedValue.ToString();

        int cant;
        foreach (DataRow item in table.Rows)
        {
            
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

                    break;
                }
                
            }
            
            
        }
        table.Rows.Add(cmbProd.SelectedValue.ToString(), Convert.ToInt32(txtcan.Text),
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
        }

        private void repositoryItemHyperLinkEdit1_Click(object sender, EventArgs e)
        {
            table.Rows[gridView1.GetSelectedRows().FirstOrDefault()].Delete();
            txttotal.Text = "S/. " + table.Compute("SUM(PRECIO)", "").ToString() + ".00";
        }


    }
}
