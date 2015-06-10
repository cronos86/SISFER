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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.CalcEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_FERRETERIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.compraBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(30, 407);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(651, 106);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
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
            this.button1.Location = new System.Drawing.Point(702, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.radioGroup1);
            this.groupControl1.Controls.Add(this.textEdit4);
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Location = new System.Drawing.Point(30, 40);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(651, 122);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Datos de Compra:";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(525, 49);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Compra"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Venta")});
            this.radioGroup1.Size = new System.Drawing.Size(100, 60);
            this.radioGroup1.TabIndex = 9;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(341, 90);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(100, 20);
            this.textEdit4.TabIndex = 8;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(341, 46);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(130, 20);
            this.textEdit3.TabIndex = 7;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(28, 89);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(262, 20);
            this.textEdit2.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(341, 73);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Monto Total:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(525, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tipo Comprobante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nº Documento:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripcion:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(127, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nombre Proveedor o RUC:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(28, 49);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(262, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.textEdit8);
            this.groupControl2.Controls.Add(this.checkEdit1);
            this.groupControl2.Controls.Add(this.textEdit7);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.textEdit5);
            this.groupControl2.Controls.Add(this.textEdit6);
            this.groupControl2.Location = new System.Drawing.Point(30, 177);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(651, 213);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "groupControl2";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(310, 25);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 13);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Precio Unid.:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(187, 25);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Cantidad:";
            // 
            // textEdit8
            // 
            this.textEdit8.Location = new System.Drawing.Point(525, 40);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Size = new System.Drawing.Size(84, 20);
            this.textEdit8.TabIndex = 5;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(433, 40);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Descuento";
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 4;
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(310, 41);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Size = new System.Drawing.Size(84, 20);
            this.textEdit7.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(34, 25);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Producto:";
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(34, 41);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(100, 20);
            this.textEdit5.TabIndex = 0;
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(187, 41);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit6.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textEdit6.Size = new System.Drawing.Size(72, 20);
            this.textEdit6.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.simpleButton1.Location = new System.Drawing.Point(319, 70);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Agregar";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(433, 70);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "simpleButton2";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(525, 69);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 9;
            this.simpleButton3.Text = "simpleButton3";
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.Location = new System.Drawing.Point(43, 113);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(566, 100);
            this.gridControl2.TabIndex = 10;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // frmCompras_prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 525);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmCompras_prueba";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_FERRETERIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.CalcEdit textEdit6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}