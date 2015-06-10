using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraEditors.Repository;

namespace SISFER
{
    public partial class frmPrueba_CardView : Form
    {
        public frmPrueba_CardView()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("server=PROPIETARIO\\SQLRAMSES;integrated security=SSPI;database=BD_FERRETERIA");

        private void frmPrueba_CardView_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da1 = new SqlDataAdapter("select * from categoria", cn);
            SqlDataAdapter da2 = new SqlDataAdapter("select * from producto", cn);

            DataSet ds = new DataSet();
            da1.Fill(ds, "Categoria");
            da2.Fill(ds, "Producto");

            DataColumn keycol = ds.Tables["Categoria"].Columns["cod_cat"];
            DataColumn fkcol = ds.Tables["Producto"].Columns["cod_cat"];
            ds.Relations.Add("Categoriaxproducto", keycol, fkcol);

            gridControl1.DataSource = ds.Tables["Categoria"];
            gridControl1.ForceInitialize();

            gridControl2.DataSource = ds.Tables["Categoria"];
            gridControl2.ForceInitialize();

            CardView cv1 = new CardView(gridControl2);
            gridControl2.LevelTree.Nodes.Add("Categoriaxproducto", cv1);
            cv1.ViewCaption = "Producto x Categoria";
            gridView2.Columns["cod_cat"].VisibleIndex = -1;

            RepositoryItemPictureEdit rip = gridControl2.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
            gridView2.Columns["cat_img"].ColumnEdit = rip;

            rip.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            gridView2.Columns["cat_img"].OptionsColumn.FixedWidth = true;
            gridView2.Columns["cat_img"].Width = 180;

            gridView2.RowHeight = 50;

            cv1.PopulateColumns(ds.Tables["Producto"]);
            cv1.Columns["cod_cat"].VisibleIndex = -1;

        }
    }
}
