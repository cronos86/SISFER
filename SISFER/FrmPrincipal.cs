﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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
    public partial class FrmPrincipal : XtraForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            BarItem bi = null;
           /* 
            bi.Name = "cbxcb";

            rcMenu.Items.Add(bi);
            
 */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCompras_prueba frm = new frmCompras_prueba();

            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPrueba_CardView frm2 = new frmPrueba_CardView();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClientPanel formrbn = new ClientPanel();

            formrbn.Show();
        }
    }
}
