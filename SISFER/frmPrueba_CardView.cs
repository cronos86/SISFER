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
using NEGOCIO;
using ENTIDAD;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
//using DevExpress.Xpf.Grid;

namespace SISFER
{
    public partial class frmPrueba_CardView : Form
    {
        public frmPrueba_CardView()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(clsConexion.cadConexion());

        private void frmPrueba_CardView_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_FERRETERIADataSet1.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.bD_FERRETERIADataSet1.Categoria);
            // TODO: esta línea de código carga datos en la tabla 'bD_FERRETERIADataSet1.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.bD_FERRETERIADataSet1.Producto);

            ejecutarcodigo();
            //pictureEdit1.Image = Image.FromFile(@"Images\pintura.jpg");

            //this.categoriaTableAdapter.Fill(this.bD_FERRETERIADataSet1.Categoria);
           // gridControl gc = new GridControl();
            //gridControl3.DataSource = neg_Categoria.listaCategoriasNE();


            /*
            RepositoryItemPictureEdit item = new RepositoryItemPictureEdit();

            gridControl3.RepositoryItems.Add(item);

            gridView3.Columns["cat_img"].ColumnEdit = item;

            DataTable dt = new DataTable();

            dt.Columns.Add("Photo");

            dt.Columns.Add("Test");

            dt.Rows.Add(Image.FromFile(@"..\pintura.jpg"), "test1");

            dt.Rows.Add(Image.FromFile(@"..\Resources\pintura.jpg"), "test2");

            dt.Rows.Add(Image.FromFile(@"Resources\pintura.jpg"), "test3");

            gridControl3.DataSource = dt;
            */
        }

        void ejecutarcodigo()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select * from categoria", cn);
            SqlDataAdapter da2 = new SqlDataAdapter("select cod_pro,cod_cat,pro_nom,pro_des,pro_mar,pro_mod from producto", cn);

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


        string ImageDir = @"C:\Users\USUARIO\Documents\GitHub\HadesFinal\SISFER\Images\";

        Hashtable Images = new Hashtable();



        string GetFileName(string color)
        {

            if (color == null || color == string.Empty)

                return string.Empty;

            return color + ".jpg";

        }

        private void cardView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "cat_img" && e.IsGetData)
            {

                GridView view = sender as GridView;


                string colorName = (string)((DataRowView)e.Row)["cat_img"];
               // string colorName = (string)gridView3.GetRowCellValue(e.ListSourceRowIndex, "cat_img");

                string fileName = GetFileName(colorName).ToLower();

                if (!Images.ContainsKey(fileName))
                {

                    Image img = null;

                    try
                    {

                        string filePath = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, ImageDir + fileName, false);

                        img = Image.FromFile(filePath);

                    }

                    catch
                    {

                    }

                    Images.Add(fileName, img);

                }

                e.Value = Images[fileName];

            }

            //
        }
    }
}
