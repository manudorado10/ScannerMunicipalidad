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
//using System.Net.NetworkInformation;

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
            //bool isConnected = Internet();
            //if (isConnected)
            //{

            if (Environment.GetCommandLineArgs().Length > 1)
            {
                if (Directory.Exists(ConfigurationManager.AppSettings["pathOrigen"]))
                {
                    if (Directory.Exists(ConfigurationManager.AppSettings["pathDestino"]))
                    {
                        IniciarScanner();
                        MoverArchivos();
                    }
                    else
                    {
                        MessageBox.Show("El directorio destino no se encuentra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El directorio origen no se encuentra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los parametros enviados son nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            //}
            //else
            //{
            //    MessageBox.Show("Comprobar la conexion de internet", "Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        /*
        public static bool Internet()
        {
            try
            {
                using (var ping = new Ping())
                {
                    const string pingAddress = "www.google.com"; // Puedes usar cualquier dirección web
                    const int timeout = 3000; // 3 segundos de tiempo de espera para la respuesta

                    var reply = ping.Send(pingAddress, timeout);
                    return (reply.Status == IPStatus.Success);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }*/

        public void MoverArchivos()
        {
            DirectoryInfo dir = new DirectoryInfo(ConfigurationManager.AppSettings["pathOrigen"]);

            if (dir.GetFiles().Count() == 1)
            {
                foreach (FileInfo file in dir.GetFiles())
                {
                    string antName = file.FullName;
                    if (GetFileName()!="")
                    {
                        
                        try
                        {
                            file.MoveTo(Path.Combine(ConfigurationManager.AppSettings["pathDestino"], GetFileName() + ".pdf"));
                            MessageBox.Show("El archivo fue movido correctamente", "Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception e) 
                        {
                            MessageBox.Show("El movimiento fallo: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    DeleteFileOrigen(antName);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("No existen archivos para mover", "Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                    startArgs.FileName = ConfigurationManager.AppSettings["pathScanner"]; 
                    startArgs.Arguments = null;

                    Process process = new Process();
                    process.StartInfo = startArgs;
                    starProcess = process.Start();

                    Process startedProcess = CheckIfProcessStarted(process);
                    if (starProcess == true)
                    {
                        lblEstado.Text = "EN PROCESO";
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
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                return Environment.GetCommandLineArgs()[1];
            }
            else
            {
                MessageBox.Show("Los parametros enviados son nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
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
        
        private void DeleteFileOrigen(string oldName)  
        {
            if (File.Exists(oldName) == true)
            {
                try
                {
                    File.Delete(oldName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("El borrado fallo: {0}" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
