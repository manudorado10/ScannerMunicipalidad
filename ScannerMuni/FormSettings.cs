using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace ScannerMuni
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            txtOriginFolder.Text = ConfigurationManager.AppSettings["pathOrigen"];
            txtDestinationFolder.Text = ConfigurationManager.AppSettings["pathDestino"];
            txtScannerPath.Text = ConfigurationManager.AppSettings["pathScanner"];
            txtFileName.Text = ConfigurationManager.AppSettings["pathFileName"];
        }

        private void btnOriginFolder_Click(object sender, EventArgs e)
        {
            if (fBDOrigin.ShowDialog() == DialogResult.OK)
            {
                txtOriginFolder.Text = fBDOrigin.SelectedPath;
                
            }
        }

        private void btnDestinatioFolder_Click(object sender, EventArgs e)
        {
            if (fBDestination.ShowDialog() == DialogResult.OK)
            {
                txtDestinationFolder.Text = fBDestination.SelectedPath;
                
            }

        }

        private void btnScannerPath_Click(object sender, EventArgs e)
        {
            if (oFDScanner.ShowDialog() == DialogResult.OK)
            {
                txtScannerPath.Text = oFDScanner.FileName;
                
            }

        }

        private void btnFileNamePath_Click(object sender, EventArgs e)
        {
            if (oFDNames.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = oFDNames.FileName;
                
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ActualizarConfiguracion("pathOrigen", txtOriginFolder.Text);
            ActualizarConfiguracion("pathDestino", txtDestinationFolder.Text);
            ActualizarConfiguracion("pathScanner", txtScannerPath.Text);
            ActualizarConfiguracion("pathFileName", txtFileName.Text);
            Close();
        }

        private void ActualizarConfiguracion(string atributo, string nuevoValor)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (atributo == "pathOrigen" & ConfigurationManager.AppSettings["pathOrigen"]!= txtOriginFolder.Text)
            {
                config.AppSettings.Settings.Remove("pathOrigen");
                config.AppSettings.Settings.Add("pathOrigen", txtOriginFolder.Text);
            }
            if (atributo == "pathDestino" & ConfigurationManager.AppSettings["pathDestino"] != txtDestinationFolder.Text)
            {
                config.AppSettings.Settings.Remove("pathDestino");
                config.AppSettings.Settings.Add("pathDestino", txtDestinationFolder.Text);
            }
            if (atributo == "pathScanner" & ConfigurationManager.AppSettings["pathScanner"] != txtScannerPath.Text)
            {
                config.AppSettings.Settings.Remove("pathScanner");
                config.AppSettings.Settings.Add("pathScanner", txtScannerPath.Text);
            }
            if (atributo == "pathFileName" & ConfigurationManager.AppSettings["pathFileName"] != txtFileName.Text)
            {
                config.AppSettings.Settings.Remove("pathFileName");
                config.AppSettings.Settings.Add("pathFileName", txtFileName.Text);
            }
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
