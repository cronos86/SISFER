using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmCompras_prueba : Form
    {
        public frmCompras_prueba()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        private void frmCompras_Load(object sender, EventArgs e)
        {
            limpiarFrmCompra();
            // TODO: esta línea de código carga datos en la tabla 'bD_FERRETERIADataSet.Compra' Puede moverla o quitarla según sea necesario.
            this.compraTableAdapter.Fill(this.bD_FERRETERIADataSet.Compra);
            //this.deta_compraTableAdapter1.Fill(this.bD_FERRETERIADataSet.deta_compra);
            //prueba
            //pictureEdit1.Properties.SizeMode = PictureBoxSizeMode.CenterImage;
            listaCategoria();
            listaProductoxCategoria();
            pictureEdit1.Image = Image.FromFile(@"C:\Users\USUARIO\Documents\GitHub\HadesFinal\SISFER\Resources\pintura.jpg");

            table.Columns.Add("PRODUCTO", typeof(string));
            table.Columns.Add("CANTIDAD", typeof(int));
            table.Columns.Add("PRECIO_UNI", typeof(double));
            table.Columns.Add("PRECIO", typeof(double));
            table.Columns.Add("DSCTO", typeof(double));
        }


        void listaCategoria()
        {
            DataTable tblcate = neg_Categoria.listaCategoriasNE();
            cmbcate.DisplayMember = "cat_des";
            cmbcate.ValueMember = "cod_cat";
            cmbcate.DataSource = tblcate;


        }

        void listaProductoxCategoria()
        {
            int codcate = Convert.ToInt16(cmbcate.SelectedValue);
            
            cmbProd.DisplayMember = "pro_nom";
            cmbProd.ValueMember = "cod_pro";
            cmbProd.DataSource = neg_Producto.listaProductoxCategoriaNE(codcate);



        }

        int cant;
        public DataTable GetTable()
        {
            Double dscto = 0;
            if (txtdesc.Text!="")
            {
                dscto = Convert.ToDouble(txtdesc.Text);
            }
            //DataRow dr = table.Rows[0];
            string idprod = cmbProd.SelectedValue.ToString();


            table.Rows.Add(idprod, txtcan.Text,
                     Convert.ToDouble(txtpuni.Text), Convert.ToDouble(txtpuni.Text) * Convert.ToInt32(txtcan.Text), dscto);                     

            txttotal.Text = "S/. " + table.Compute("SUM(PRECIO)", "").ToString() + ".00";
            return table;
        }
       

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }        

        private void gridView1_Click(object sender, EventArgs e)
        {
         
           // int row = Convert.ToInt16(gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns["cod_com"]));
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int row = Convert.ToInt16(gridView1.GetRowCellValue(e.RowHandle,gridView1.Columns["cod_com"]));
            textBox1.Text = row.ToString();

            gridControl2.DataSource = neg_Compras.detalleComprasNE(Convert.ToInt16(textBox1.Text));
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GetTable();
            gridControl2.DataSource = table;

            cmbcate.SelectedIndex = -1;
            cmbProd.SelectedIndex = -1;
            txtcan.Text = "";
            txtpuni.Text = "";
            txtdesc.Enabled = false;
            txtdesc.Text = "";
            chkdscto.Checked = false;
        }

        void limpiarFrmCompra()
        {
            txtprov.Text = "";
            txtdes.Text = "";
            txtndoc.Text = "";
            //txtfec.Text = DateTime.Now.ToString();
            txttotal.Text = "";
            chkdscto.Checked = false;
            txtdesc.Text = "";
            txtdesc.Enabled = false;

            cmbcate.SelectedIndex = -1;
            cmbProd.SelectedIndex = -1;
            txtcan.Text = "";
            txtpuni.Text = "";

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            compra objc = new compra();
        }
    }


}
