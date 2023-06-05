
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
            btnPlay = new System.Windows.Forms.Button();
            fBDOrigin = new System.Windows.Forms.FolderBrowserDialog();
            fBDDestiny = new System.Windows.Forms.FolderBrowserDialog();
            lblState = new System.Windows.Forms.Label();
            oFDScanner = new System.Windows.Forms.OpenFileDialog();
            lblEstado = new System.Windows.Forms.Label();
            btnConfiguration = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Location = new System.Drawing.Point(12, 58);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new System.Drawing.Size(202, 43);
            btnPlay.TabIndex = 7;
            btnPlay.Text = "Iniciar";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnAccept_Click;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblState.Location = new System.Drawing.Point(12, 119);
            lblState.Name = "lblState";
            lblState.Size = new System.Drawing.Size(59, 21);
            lblState.TabIndex = 9;
            lblState.Text = "Estado:";
            // 
            // oFDScanner
            // 
            oFDScanner.FileName = "oFDScanner";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblEstado.Location = new System.Drawing.Point(64, 140);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new System.Drawing.Size(106, 28);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "PAUSADO";
            // 
            // btnConfiguration
            // 
            btnConfiguration.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            btnConfiguration.Location = new System.Drawing.Point(12, 12);
            btnConfiguration.Name = "btnConfiguration";
            btnConfiguration.Size = new System.Drawing.Size(202, 40);
            btnConfiguration.TabIndex = 15;
            btnConfiguration.Text = "Configuración";
            btnConfiguration.UseVisualStyleBackColor = false;
            btnConfiguration.Click += btnConfiguracion_Click;
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

