namespace OpenFL.Editor.Development.Forms
{
    partial class PluginPackageConverterForm
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
            this.tbOutputDir = new System.Windows.Forms.TextBox();
            this.tbInputDir = new System.Windows.Forms.TextBox();
            this.lblInputDir = new System.Windows.Forms.Label();
            this.lblOutputDir = new System.Windows.Forms.Label();
            this.btnSelectInputDir = new System.Windows.Forms.Button();
            this.btnSelectOutputDir = new System.Windows.Forms.Button();
            this.btnPack = new System.Windows.Forms.Button();
            this.cbPackerFormats = new System.Windows.Forms.ComboBox();
            this.lblPackerFormat = new System.Windows.Forms.Label();
            this.fbdOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdInput = new System.Windows.Forms.FolderBrowserDialog();
            this.lblInputInfo = new System.Windows.Forms.Label();
            this.lblDataFormat = new System.Windows.Forms.Label();
            this.cbDataFormats = new System.Windows.Forms.ComboBox();
            this.btnUnpack = new System.Windows.Forms.Button();
            this.panelPack = new System.Windows.Forms.Panel();
            this.rtbInputInfo = new System.Windows.Forms.RichTextBox();
            this.panelPack.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbOutputDir
            // 
            this.tbOutputDir.Location = new System.Drawing.Point(105, 7);
            this.tbOutputDir.Name = "tbOutputDir";
            this.tbOutputDir.Size = new System.Drawing.Size(375, 20);
            this.tbOutputDir.TabIndex = 0;
            this.tbOutputDir.TextChanged += new System.EventHandler(this.tbOutputDir_TextChanged);
            // 
            // tbInputDir
            // 
            this.tbInputDir.Location = new System.Drawing.Point(105, 8);
            this.tbInputDir.Name = "tbInputDir";
            this.tbInputDir.Size = new System.Drawing.Size(375, 20);
            this.tbInputDir.TabIndex = 1;
            this.tbInputDir.TextChanged += new System.EventHandler(this.tbInputDir_TextChanged);
            // 
            // lblInputDir
            // 
            this.lblInputDir.AutoSize = true;
            this.lblInputDir.Location = new System.Drawing.Point(12, 11);
            this.lblInputDir.Name = "lblInputDir";
            this.lblInputDir.Size = new System.Drawing.Size(79, 13);
            this.lblInputDir.TabIndex = 2;
            this.lblInputDir.Text = "Input Directory:";
            // 
            // lblOutputDir
            // 
            this.lblOutputDir.AutoSize = true;
            this.lblOutputDir.Location = new System.Drawing.Point(12, 10);
            this.lblOutputDir.Name = "lblOutputDir";
            this.lblOutputDir.Size = new System.Drawing.Size(87, 13);
            this.lblOutputDir.TabIndex = 3;
            this.lblOutputDir.Text = "Output Directory:";
            // 
            // btnSelectInputDir
            // 
            this.btnSelectInputDir.Location = new System.Drawing.Point(486, 6);
            this.btnSelectInputDir.Name = "btnSelectInputDir";
            this.btnSelectInputDir.Size = new System.Drawing.Size(29, 23);
            this.btnSelectInputDir.TabIndex = 4;
            this.btnSelectInputDir.Text = "...";
            this.btnSelectInputDir.UseVisualStyleBackColor = true;
            this.btnSelectInputDir.Click += new System.EventHandler(this.btnSelectInputDir_Click);
            // 
            // btnSelectOutputDir
            // 
            this.btnSelectOutputDir.Location = new System.Drawing.Point(486, 5);
            this.btnSelectOutputDir.Name = "btnSelectOutputDir";
            this.btnSelectOutputDir.Size = new System.Drawing.Size(29, 23);
            this.btnSelectOutputDir.TabIndex = 5;
            this.btnSelectOutputDir.Text = "...";
            this.btnSelectOutputDir.UseVisualStyleBackColor = true;
            this.btnSelectOutputDir.Click += new System.EventHandler(this.btnSelectOutputDir_Click);
            // 
            // btnPack
            // 
            this.btnPack.Enabled = false;
            this.btnPack.Location = new System.Drawing.Point(439, 70);
            this.btnPack.Name = "btnPack";
            this.btnPack.Size = new System.Drawing.Size(76, 23);
            this.btnPack.TabIndex = 6;
            this.btnPack.Text = "Pack";
            this.btnPack.UseVisualStyleBackColor = true;
            this.btnPack.Click += new System.EventHandler(this.btnPack_Click);
            // 
            // cbPackerFormats
            // 
            this.cbPackerFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPackerFormats.FormattingEnabled = true;
            this.cbPackerFormats.Location = new System.Drawing.Point(105, 33);
            this.cbPackerFormats.Name = "cbPackerFormats";
            this.cbPackerFormats.Size = new System.Drawing.Size(410, 21);
            this.cbPackerFormats.TabIndex = 7;
            this.cbPackerFormats.SelectedIndexChanged += new System.EventHandler(this.cbPackerFormats_SelectedIndexChanged);
            // 
            // lblPackerFormat
            // 
            this.lblPackerFormat.AutoSize = true;
            this.lblPackerFormat.Location = new System.Drawing.Point(12, 36);
            this.lblPackerFormat.Name = "lblPackerFormat";
            this.lblPackerFormat.Size = new System.Drawing.Size(79, 13);
            this.lblPackerFormat.TabIndex = 8;
            this.lblPackerFormat.Text = "Packer Format:";
            // 
            // lblInputInfo
            // 
            this.lblInputInfo.AutoSize = true;
            this.lblInputInfo.Location = new System.Drawing.Point(12, 39);
            this.lblInputInfo.Name = "lblInputInfo";
            this.lblInputInfo.Size = new System.Drawing.Size(55, 13);
            this.lblInputInfo.TabIndex = 9;
            this.lblInputInfo.Text = "Input Info:";
            // 
            // lblDataFormat
            // 
            this.lblDataFormat.AutoSize = true;
            this.lblDataFormat.Location = new System.Drawing.Point(12, 75);
            this.lblDataFormat.Name = "lblDataFormat";
            this.lblDataFormat.Size = new System.Drawing.Size(68, 13);
            this.lblDataFormat.TabIndex = 11;
            this.lblDataFormat.Text = "Data Format:";
            // 
            // cbDataFormats
            // 
            this.cbDataFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataFormats.FormattingEnabled = true;
            this.cbDataFormats.Location = new System.Drawing.Point(105, 72);
            this.cbDataFormats.Name = "cbDataFormats";
            this.cbDataFormats.Size = new System.Drawing.Size(328, 21);
            this.cbDataFormats.TabIndex = 10;
            this.cbDataFormats.SelectedIndexChanged += new System.EventHandler(this.cbDataFormats_SelectedIndexChanged);
            // 
            // btnUnpack
            // 
            this.btnUnpack.Enabled = false;
            this.btnUnpack.Location = new System.Drawing.Point(439, 55);
            this.btnUnpack.Name = "btnUnpack";
            this.btnUnpack.Size = new System.Drawing.Size(76, 23);
            this.btnUnpack.TabIndex = 12;
            this.btnUnpack.Text = "Unpack";
            this.btnUnpack.UseVisualStyleBackColor = true;
            this.btnUnpack.Click += new System.EventHandler(this.btnUnpack_Click);
            // 
            // panelPack
            // 
            this.panelPack.Controls.Add(this.lblOutputDir);
            this.panelPack.Controls.Add(this.tbOutputDir);
            this.panelPack.Controls.Add(this.lblDataFormat);
            this.panelPack.Controls.Add(this.btnSelectOutputDir);
            this.panelPack.Controls.Add(this.cbDataFormats);
            this.panelPack.Controls.Add(this.btnPack);
            this.panelPack.Controls.Add(this.cbPackerFormats);
            this.panelPack.Controls.Add(this.lblPackerFormat);
            this.panelPack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPack.Enabled = false;
            this.panelPack.Location = new System.Drawing.Point(0, 87);
            this.panelPack.Name = "panelPack";
            this.panelPack.Size = new System.Drawing.Size(523, 101);
            this.panelPack.TabIndex = 13;
            // 
            // rtbInputInfo
            // 
            this.rtbInputInfo.DetectUrls = false;
            this.rtbInputInfo.Location = new System.Drawing.Point(105, 36);
            this.rtbInputInfo.Name = "rtbInputInfo";
            this.rtbInputInfo.ReadOnly = true;
            this.rtbInputInfo.Size = new System.Drawing.Size(328, 42);
            this.rtbInputInfo.TabIndex = 14;
            this.rtbInputInfo.Text = "";
            // 
            // PluginPackageConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 188);
            this.Controls.Add(this.rtbInputInfo);
            this.Controls.Add(this.panelPack);
            this.Controls.Add(this.btnUnpack);
            this.Controls.Add(this.lblInputInfo);
            this.Controls.Add(this.btnSelectInputDir);
            this.Controls.Add(this.lblInputDir);
            this.Controls.Add(this.tbInputDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PluginPackageConverterForm";
            this.Text = "Plugin Package Converter";
            this.Load += new System.EventHandler(this.PackerWindow_Load);
            this.panelPack.ResumeLayout(false);
            this.panelPack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutputDir;
        private System.Windows.Forms.TextBox tbInputDir;
        private System.Windows.Forms.Label lblInputDir;
        private System.Windows.Forms.Label lblOutputDir;
        private System.Windows.Forms.Button btnSelectInputDir;
        private System.Windows.Forms.Button btnSelectOutputDir;
        private System.Windows.Forms.Button btnPack;
        private System.Windows.Forms.ComboBox cbPackerFormats;
        private System.Windows.Forms.Label lblPackerFormat;
        private System.Windows.Forms.FolderBrowserDialog fbdOutput;
        private System.Windows.Forms.FolderBrowserDialog fbdInput;
        private System.Windows.Forms.Label lblInputInfo;
        private System.Windows.Forms.Label lblDataFormat;
        private System.Windows.Forms.ComboBox cbDataFormats;
        private System.Windows.Forms.Button btnUnpack;
        private System.Windows.Forms.Panel panelPack;
        private System.Windows.Forms.RichTextBox rtbInputInfo;
    }
}