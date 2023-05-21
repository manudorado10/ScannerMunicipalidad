using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerMuni
{
    public partial class PassForm : Form
    {
        bool _pass = false;

        public PassForm()
        {
            InitializeComponent();
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            validarPass();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        public bool validarPass() 
        {
            if (this.txtPass.Text == "123456")
            {
                _pass = true;
            }
            else { _pass = false; }

            return _pass;
        }
    }
}
