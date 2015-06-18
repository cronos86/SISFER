namespace SISFER
{
    partial class frmPrueba_CardView
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bD_FERRETERIADataSet1 = new SISFER.BD_FERRETERIADataSet1();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new SISFER.BD_FERRETERIADataSet1TableAdapters.ProductoTableAdapter();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new SISFER.BD_FERRETERIADataSet1TableAdapters.CategoriaTableAdapter();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.categoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colcod_cat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcat_des = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcat_img = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_FERRETERIADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(37, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(731, 206);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.Location = new System.Drawing.Point(37, 236);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(731, 338);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // bD_FERRETERIADataSet1
            // 
            this.bD_FERRETERIADataSet1.DataSetName = "BD_FERRETERIADataSet1";
            this.bD_FERRETERIADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.bD_FERRETERIADataSet1;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.bD_FERRETERIADataSet1;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl3
            // 
            this.gridControl3.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl3.DataSource = this.categoriaBindingSource1;
            this.gridControl3.Location = new System.Drawing.Point(774, 12);
            this.gridControl3.MainView = this.cardView1;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit2,
            this.repositoryItemPictureEdit3});
            this.gridControl3.Size = new System.Drawing.Size(436, 402);
            this.gridControl3.TabIndex = 2;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1,
            this.gridView3});
            // 
            // categoriaBindingSource1
            // 
            this.categoriaBindingSource1.DataMember = "Categoria";
            this.categoriaBindingSource1.DataSource = this.bD_FERRETERIADataSet1;
            // 
            // cardView1
            // 
            this.cardView1.Appearance.CardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.cardView1.Appearance.CardCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.cardView1.Appearance.CardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.cardView1.Appearance.CardCaption.ForeColor = System.Drawing.Color.Black;
            this.cardView1.Appearance.CardCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.cardView1.Appearance.CardCaption.Options.UseBackColor = true;
            this.cardView1.Appearance.CardCaption.Options.UseBorderColor = true;
            this.cardView1.Appearance.CardCaption.Options.UseForeColor = true;
            this.cardView1.Appearance.EmptySpace.BackColor = System.Drawing.Color.White;
            this.cardView1.Appearance.EmptySpace.Options.UseBackColor = true;
            this.cardView1.Appearance.FieldCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.cardView1.Appearance.FieldCaption.ForeColor = System.Drawing.Color.Black;
            this.cardView1.Appearance.FieldCaption.Options.UseBackColor = true;
            this.cardView1.Appearance.FieldCaption.Options.UseForeColor = true;
            this.cardView1.Appearance.FieldValue.BackColor = System.Drawing.Color.White;
            this.cardView1.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black;
            this.cardView1.Appearance.FieldValue.Options.UseBackColor = true;
            this.cardView1.Appearance.FieldValue.Options.UseForeColor = true;
            this.cardView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.cardView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.cardView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.cardView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.cardView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.cardView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.cardView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.cardView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.cardView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.cardView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.cardView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.cardView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.cardView1.Appearance.FocusedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.cardView1.Appearance.FocusedCardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.cardView1.Appearance.FocusedCardCaption.ForeColor = System.Drawing.Color.White;
            this.cardView1.Appearance.FocusedCardCaption.Options.UseBackColor = true;
            this.cardView1.Appearance.FocusedCardCaption.Options.UseBorderColor = true;
            this.cardView1.Appearance.FocusedCardCaption.Options.UseForeColor = true;
            this.cardView1.Appearance.HideSelectionCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.cardView1.Appearance.HideSelectionCardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.cardView1.Appearance.HideSelectionCardCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.cardView1.Appearance.HideSelectionCardCaption.Options.UseBackColor = true;
            this.cardView1.Appearance.HideSelectionCardCaption.Options.UseBorderColor = true;
            this.cardView1.Appearance.HideSelectionCardCaption.Options.UseForeColor = true;
            this.cardView1.Appearance.SelectedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.cardView1.Appearance.SelectedCardCaption.ForeColor = System.Drawing.Color.White;
            this.cardView1.Appearance.SelectedCardCaption.Options.UseBackColor = true;
            this.cardView1.Appearance.SelectedCardCaption.Options.UseForeColor = true;
            this.cardView1.Appearance.SeparatorLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.cardView1.Appearance.SeparatorLine.Options.UseBackColor = true;
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcod_cat,
            this.colcat_des,
            this.colcat_img,
            this.gridColumn1});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl3;
            this.cardView1.Name = "cardView1";
            this.cardView1.PaintStyleName = "Flat";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // colcod_cat
            // 
            this.colcod_cat.FieldName = "cod_cat";
            this.colcod_cat.Name = "colcod_cat";
            this.colcod_cat.OptionsColumn.ReadOnly = true;
            this.colcod_cat.Visible = true;
            this.colcod_cat.VisibleIndex = 0;
            // 
            // colcat_des
            // 
            this.colcat_des.FieldName = "cat_des";
            this.colcat_des.Name = "colcat_des";
            this.colcat_des.Visible = true;
            this.colcat_des.VisibleIndex = 1;
            // 
            // colcat_img
            // 
            this.colcat_img.ColumnEdit = this.repositoryItemPictureEdit3;
            this.colcat_img.FieldName = "@\"C:\\Users\\USUARIO\\Documents\\GitHub\\HadesFinal\\SISFER\\Resources\\\"+cat_img";
            this.colcat_img.Name = "colcat_img";
            this.colcat_img.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colcat_img.Visible = true;
            this.colcat_img.VisibleIndex = 2;
            // 
            // repositoryItemPictureEdit3
            // 
            this.repositoryItemPictureEdit3.Name = "repositoryItemPictureEdit3";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.ColumnEdit = this.repositoryItemPictureEdit1;
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn1.FieldName = "cat_img";
            this.gridColumn1.FieldNameSortGroup = "cod_cat";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.AccessibleName = "";
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AccessibleDescription = "";
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.repositoryItemImageEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image;
            this.repositoryItemImageEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            // 
            // frmPrueba_CardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 586);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmPrueba_CardView";
            this.Text = "frmPrueba_CardView";
            this.Load += new System.EventHandler(this.frmPrueba_CardView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_FERRETERIADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BD_FERRETERIADataSet1 bD_FERRETERIADataSet1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private BD_FERRETERIADataSet1TableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private BD_FERRETERIADataSet1TableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private System.Windows.Forms.BindingSource categoriaBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_cat;
        private DevExpress.XtraGrid.Columns.GridColumn colcat_des;
        private DevExpress.XtraGrid.Columns.GridColumn colcat_img;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit3;
    }
}