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
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_FERRETERIADataSet = new SISFER.BD_FERRETERIADataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcod_com = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcom_prov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_tdoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcom_doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcom_des = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcom_fec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcom_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcom_anulado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcom_usureg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcom_usumod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcom_usuanu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.compraTableAdapter = new SISFER.BD_FERRETERIADataSetTableAdapters.CompraTableAdapter();
            this.deta_compraTableAdapter1 = new SISFER.BD_FERRETERIADataSetTableAdapters.deta_compraTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_FERRETERIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.compraBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(30, 44);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(693, 275);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "Compra";
            this.compraBindingSource.DataSource = this.bD_FERRETERIADataSet;
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
            this.colcom_total,
            this.colcom_anulado,
            this.colcom_usureg,
            this.colcom_usumod,
            this.colcom_usuanu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            // colcom_anulado
            // 
            this.colcom_anulado.FieldName = "com_anulado";
            this.colcom_anulado.Name = "colcom_anulado";
            this.colcom_anulado.Visible = true;
            this.colcom_anulado.VisibleIndex = 7;
            // 
            // colcom_usureg
            // 
            this.colcom_usureg.FieldName = "com_usureg";
            this.colcom_usureg.Name = "colcom_usureg";
            this.colcom_usureg.Visible = true;
            this.colcom_usureg.VisibleIndex = 8;
            // 
            // colcom_usumod
            // 
            this.colcom_usumod.FieldName = "com_usumod";
            this.colcom_usumod.Name = "colcom_usumod";
            this.colcom_usumod.Visible = true;
            this.colcom_usumod.VisibleIndex = 9;
            // 
            // colcom_usuanu
            // 
            this.colcom_usuanu.FieldName = "com_usuanu";
            this.colcom_usuanu.Name = "colcom_usuanu";
            this.colcom_usuanu.Visible = true;
            this.colcom_usuanu.VisibleIndex = 10;
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // deta_compraTableAdapter1
            // 
            this.deta_compraTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_FERRETERIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

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
        private DevExpress.XtraGrid.Columns.GridColumn colcom_anulado;
        private DevExpress.XtraGrid.Columns.GridColumn colcom_usureg;
        private DevExpress.XtraGrid.Columns.GridColumn colcom_usumod;
        private DevExpress.XtraGrid.Columns.GridColumn colcom_usuanu;
        private BD_FERRETERIADataSetTableAdapters.deta_compraTableAdapter deta_compraTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}