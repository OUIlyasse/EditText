using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EditText
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtText_Validating(object sender, CancelEventArgs e)
        {
            txtResult.Text = txtText.Text.ToLower();
            if (ckbSave.Checked)
                Clipboard.SetText(txtResult.Text);
        }
    }
}