using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.deta_compraTableAdapter1.Fill(this.bD_FERRETERIADataSet.deta_compra);
            //prueba

        }
    }
}
