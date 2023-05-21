using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Configuration;

namespace ScannerMuni
{
    public partial class Scanner : Form
    {
        public Scanner()
        {
            InitializeComponent();
            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            IniciarScanner();
            MoverArchivos();
            
        }

        public void MoverArchivos()
        {
            string srcDir = ConfigurationManager.AppSettings["pathOrigen"];
            string destDir = ConfigurationManager.AppSettings["pathDestino"];

            DirectoryInfo dir = new DirectoryInfo(srcDir);
            if (Directory.Exists(srcDir))
            {
                if (Directory.Exists(destDir))
                {
                    if (dir.GetFiles().Count() > 0)
                    {
                        if (MessageBox.Show($"¿Desea mover los {dir.GetFiles().Count()} archivos de la carpeta origen?", "Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (FileInfo file in dir.GetFiles())
                            {
                                string newFileName = GetFileName() + ".pdf";
                                if (!File.Exists(Path.Combine(destDir, newFileName)))
                                {
                                    file.MoveTo(Path.Combine(destDir, newFileName));
                                    MessageBox.Show("Archivo movido con exito", "ScannerInfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else{ MessageBox.Show("Ya existe un archivo con ese nombre", "ScannerInfo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            }
                        }
                    }
                    else { MessageBox.Show("No existen archivos en la carpeta origen", "ScannerInfo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else { MessageBox.Show("El directorio destino no encontrado", "ScannerInfo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("El directorio origen no encontrado", "ScannerInfo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void IniciarScanner()
        {
            try
            {

                bool pathExists = File.Exists(ConfigurationManager.AppSettings["pathScanner"]);
                if (pathExists)
                {
                    bool starProcess = false;
                    ProcessStartInfo startArgs = new ProcessStartInfo();
                    startArgs.FileName = ConfigurationManager.AppSettings["pathScanner"]; // direccion del .exe del scanner C:\WINDOWS\system32\notepad.exe
                    startArgs.Arguments = null;

                    Process process = new Process();
                    process.StartInfo = startArgs;
                    starProcess = process.Start();

                    Process startedProcess = CheckIfProcessStarted(process);
                    if (starProcess == true)
                    {
                        lblEstado.Text = "TRABAJANDO";
                    }
                    process.WaitForExit();
                    if (process.HasExited == true)
                    {
                        lblEstado.Text = "PAUSADO";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "  " + ex.InnerException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Process CheckIfProcessStarted(Process process)
        {
            return Process.GetProcessById(process.Id);
        }

        private string GetFileName() 
        {
            string filePath = ConfigurationManager.AppSettings["pathFileName"];
            string filename = ReadArgumentsFromFile(filePath);

            if (!string.IsNullOrEmpty(filename))
            {
                return filename;
            }
            else 
            { 
                MessageBox.Show("Nombre de archivo no encontrado", "FileName", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        static string ReadArgumentsFromFile(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    return sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo de argumentos: " + ex.Message, "FileName", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            PassForm validacion = new PassForm();
            if (validacion.ShowDialog() == DialogResult.OK)
            {
                if (validacion.validarPass() == true)
                {
                    FormSettings configuracion = new FormSettings();
                    configuracion.ShowDialog();
                }
            }
        }
    }

    
}
