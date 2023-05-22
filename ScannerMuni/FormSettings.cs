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
using System.Xml;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ActualizarConfiguracion("pathOrigen", txtOriginFolder.Text);
            ActualizarConfiguracion("pathDestino", txtDestinationFolder.Text);
            ActualizarConfiguracion("pathScanner", txtScannerPath.Text);
            Close();
        }

        private void ActualizarConfiguracion(string atributo, string nuevoValor)
        {
            XmlDocument configuracion = new XmlDocument();
            configuracion.Load(ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).FilePath);
            foreach (XmlElement element in configuracion.DocumentElement) 
            {
                if (element.Name.Equals("appSettings")) 
                {
                    foreach (XmlNode node in element.ChildNodes) 
                    {
                        if (node.Attributes[0].Value == atributo && node.Attributes[1].Value != nuevoValor) 
                        {
                            node.Attributes[1].Value = nuevoValor;
                        }
                    }
                }
            }
            configuracion.Save(ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).FilePath);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
