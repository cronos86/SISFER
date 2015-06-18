namespace SISFER
{
    partial class frmCompras_prueba
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.compraBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bDFERRETERIADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_FERRETERIADataSet = new SISFER.BD_FERRETERIADataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcod_com = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcom_prov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_tdoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcom_doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcom_des = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcom_fec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcom_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.compraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraTableAdapter = new SISFER.BD_FERRETERIADataSetTableAdapters.CompraTableAdapter();
            this.deta_compraTableAdapter1 = new SISFER.BD_FERRETERIADataSetTableAdapters.deta_compraTableAdapter();
            this.detacompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDFERRETERIADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_FERRETERIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detacompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.compraBindingSource2;
            this.gridControl1.Location = new System.Drawing.Point(50, 54);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(620, 368);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // compraBindingSource2
            // 
            this.compraBindingSource2.DataMember = "Compra";
            this.compraBindingSource2.DataSource = this.bDFERRETERIADataSetBindingSource;
            // 
            // bDFERRETERIADataSetBindingSource
            // 
            this.bDFERRETERIADataSetBindingSource.DataSource = this.bD_FERRETERIADataSet;
            this.bDFERRETERIADataSetBindingSource.Position = 0;
            // 
            // bD_FERRETERIADataSet
            // 
            this.bD_FERRETERIADataSet.DataSetName = "BD_FERRETERIADataSet";
            this.bD_FERRETERIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcod_com,
            this.colcom_prov,
            this.colcod_tdoc,
            this.colcom_doc,
            this.colcom_des,
            this.colcom_fec,
            this.colcom_total});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colcod_com
            // 
            this.colcod_com.FieldName = "cod_com";
            this.colcod_com.Name = "colcod_com";
            this.colcod_com.OptionsColumn.ReadOnly = true;
            this.colcod_com.Visible = true;
            this.colcod_com.VisibleIndex = 0;
            // 
            // colcom_prov
            // 
            this.colcom_prov.FieldName = "com_prov";
            this.colcom_prov.Name = "colcom_prov";
            this.colcom_prov.Visible = true;
            this.colcom_prov.VisibleIndex = 1;
            // 
            // colcod_tdoc
            // 
            this.colcod_tdoc.FieldName = "cod_tdoc";
            this.colcod_tdoc.Name = "colcod_tdoc";
            this.colcod_tdoc.Visible = true;
            this.colcod_tdoc.VisibleIndex = 2;
            // 
            // colcom_doc
            // 
            this.colcom_doc.FieldName = "com_doc";
            this.colcom_doc.Name = "colcom_doc";
            this.colcom_doc.Visible = true;
            this.colcom_doc.VisibleIndex = 3;
            // 
            // colcom_des
            // 
            this.colcom_des.FieldName = "com_des";
            this.colcom_des.Name = "colcom_des";
            this.colcom_des.Visible = true;
            this.colcom_des.VisibleIndex = 4;
            // 
            // colcom_fec
            // 
            this.colcom_fec.FieldName = "com_fec";
            this.colcom_fec.Name = "colcom_fec";
            this.colcom_fec.Visible = true;
            this.colcom_fec.VisibleIndex = 5;
            // 
            // colcom_total
            // 
            this.colcom_total.FieldName = "com_total";
            this.colcom_total.Name = "colcom_total";
            this.colcom_total.Visible = true;
            this.colcom_total.VisibleIndex = 6;
            // 
            // compraBindingSource1
            // 
            this.compraBindingSource1.DataMember = "Compra";
            this.compraBindingSource1.DataSource = this.bDFERRETERIADataSetBindingSource;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "Compra";
            this.compraBindingSource.DataSource = this.bD_FERRETERIADataSet;
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // deta_compraTableAdapter1
            // 
            this.deta_compraTableAdapter1.ClearBeforeFill = true;
            // 
            // detacompraBindingSource
            // 
            this.detacompraBindingSource.DataMember = "deta_compra";
            this.detacompraBindingSource.DataSource = this.bDFERRETERIADataSetBindingSource;
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.Location = new System.Drawing.Point(749, 54);
            this.gridControl2.MainView = this.cardView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(478, 368);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.CardInterval = 6;
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl2;
            this.cardView1.MaximumCardColumns = 2;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(643, 428);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(144, 428);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 3;
            // 
            // frmCompras_prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 525);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmCompras_prueba";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDFERRETERIADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_FERRETERIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detacompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BD_FERRETERIADataSet bD_FERRETERIADataSet;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private BD_FERRETERIADataSetTableAdapters.CompraTableAdapter compraTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_com;
        private DevExpress.XtraGrid.Columns.GridColumn colcom_prov;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_tdoc;
        private DevExpress.XtraGrid.Columns.GridColumn colcom_doc;
        private DevExpress.XtraGrid.Columns.GridColumn colcom_des;
        private DevExpress.XtraGrid.Columns.GridColumn colcom_fec;
        private DevExpress.XtraGrid.Columns.GridColumn colcom_total;
        private BD_FERRETERIADataSetTableAdapters.deta_compraTableAdapter deta_compraTableAdapter1;
        private System.Windows.Forms.BindingSource compraBindingSource1;
        private System.Windows.Forms.BindingSource bDFERRETERIADataSetBindingSource;
        private System.Windows.Forms.BindingSource detacompraBindingSource;
        private System.Windows.Forms.BindingSource compraBindingSource2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}