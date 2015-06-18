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

namespace SISFER
{
    public partial class frmCompras_prueba : Form
    {
        public frmCompras_prueba()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'bD_FERRETERIADataSet.Compra' Puede moverla o quitarla según sea necesario.
            this.compraTableAdapter.Fill(this.bD_FERRETERIADataSet.Compra);
            //this.deta_compraTableAdapter1.Fill(this.bD_FERRETERIADataSet.deta_compra);
            //prueba
            //pictureEdit1.Properties.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureEdit1.Image = Image.FromFile(@"C:\Users\USUARIO\Documents\GitHub\HadesFinal\SISFER\Resources\pintura.jpg");
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
    }
}
