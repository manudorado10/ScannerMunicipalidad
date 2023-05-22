
namespace ScannerMuni
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtOriginFolder = new System.Windows.Forms.TextBox();
            this.btnOriginFolder = new System.Windows.Forms.Button();
            this.btnDestinatioFolder = new System.Windows.Forms.Button();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnScannerPath = new System.Windows.Forms.Button();
            this.txtScannerPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.fBDOrigin = new System.Windows.Forms.FolderBrowserDialog();
            this.fBDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.oFDScanner = new System.Windows.Forms.OpenFileDialog();
            this.oFDNames = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carpeta origen";
            // 
            // txtOriginFolder
            // 
            this.txtOriginFolder.Location = new System.Drawing.Point(133, 9);
            this.txtOriginFolder.Name = "txtOriginFolder";
            this.txtOriginFolder.Size = new System.Drawing.Size(490, 23);
            this.txtOriginFolder.TabIndex = 4;
            // 
            // btnOriginFolder
            // 
            this.btnOriginFolder.Location = new System.Drawing.Point(629, 9);
            this.btnOriginFolder.Name = "btnOriginFolder";
            this.btnOriginFolder.Size = new System.Drawing.Size(39, 23);
            this.btnOriginFolder.TabIndex = 5;
            this.btnOriginFolder.Text = "/..";
            this.btnOriginFolder.UseVisualStyleBackColor = true;
            this.btnOriginFolder.Click += new System.EventHandler(this.btnOriginFolder_Click);
            // 
            // btnDestinatioFolder
            // 
            this.btnDestinatioFolder.Location = new System.Drawing.Point(629, 38);
            this.btnDestinatioFolder.Name = "btnDestinatioFolder";
            this.btnDestinatioFolder.Size = new System.Drawing.Size(39, 23);
            this.btnDestinatioFolder.TabIndex = 8;
            this.btnDestinatioFolder.Text = "/..";
            this.btnDestinatioFolder.UseVisualStyleBackColor = true;
            this.btnDestinatioFolder.Click += new System.EventHandler(this.btnDestinatioFolder_Click);
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Location = new System.Drawing.Point(133, 38);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(490, 23);
            this.txtDestinationFolder.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Carpeta destino";
            // 
            // btnScannerPath
            // 
            this.btnScannerPath.Location = new System.Drawing.Point(629, 67);
            this.btnScannerPath.Name = "btnScannerPath";
            this.btnScannerPath.Size = new System.Drawing.Size(39, 23);
            this.btnScannerPath.TabIndex = 11;
            this.btnScannerPath.Text = "/..";
            this.btnScannerPath.UseVisualStyleBackColor = true;
            this.btnScannerPath.Click += new System.EventHandler(this.btnScannerPath_Click);
            // 
            // txtScannerPath
            // 
            this.txtScannerPath.Location = new System.Drawing.Point(133, 67);
            this.txtScannerPath.Name = "txtScannerPath";
            this.txtScannerPath.Size = new System.Drawing.Size(490, 23);
            this.txtScannerPath.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Scanner:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(466, 96);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(98, 27);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(570, 96);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 27);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Cancelar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // oFDScanner
            // 
            this.oFDScanner.FileName = "openFileDialog1";
            // 
            // oFDNames
            // 
            this.oFDNames.FileName = "openFileDialog2";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 131);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnScannerPath);
            this.Controls.Add(this.txtScannerPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDestinatioFolder);
            this.Controls.Add(this.txtDestinationFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOriginFolder);
            this.Controls.Add(this.txtOriginFolder);
            this.Controls.Add(this.label1);
            this.Name = "FormSettings";
            this.Text = "Configuración";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOriginFolder;
        private System.Windows.Forms.Button btnOriginFolder;
        private System.Windows.Forms.Button btnDestinatioFolder;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnScannerPath;
        private System.Windows.Forms.TextBox txtScannerPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FolderBrowserDialog fBDOrigin;
        private System.Windows.Forms.FolderBrowserDialog fBDestination;
        private System.Windows.Forms.OpenFileDialog oFDScanner;
        private System.Windows.Forms.OpenFileDialog oFDNames;
    }
}