
namespace ScannerMuni
{
    partial class Scanner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlay = new System.Windows.Forms.Button();
            this.fBDOrigin = new System.Windows.Forms.FolderBrowserDialog();
            this.fBDDestiny = new System.Windows.Forms.FolderBrowserDialog();
            this.lblState = new System.Windows.Forms.Label();
            this.oFDScanner = new System.Windows.Forms.OpenFileDialog();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 58);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(202, 43);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Iniciar";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblState.Location = new System.Drawing.Point(12, 119);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(59, 21);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "Estado:";
            // 
            // oFDScanner
            // 
            this.oFDScanner.FileName = "oFDScanner";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.Location = new System.Drawing.Point(64, 140);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(106, 28);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "PAUSADO";
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConfiguration.Location = new System.Drawing.Point(12, 12);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(202, 40);
            this.btnConfiguration.TabIndex = 15;
            this.btnConfiguration.Text = "Configuración";
            this.btnConfiguration.UseVisualStyleBackColor = false;
            this.btnConfiguration.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 177);
            this.Controls.Add(this.btnConfiguration);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Scanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.FolderBrowserDialog fBDOrigin;
        private System.Windows.Forms.FolderBrowserDialog fBDDestiny;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.OpenFileDialog oFDScanner;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnConfiguration;
    }
}

