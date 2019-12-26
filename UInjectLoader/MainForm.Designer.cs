namespace UInjectLoader
{
    partial class MainForm
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
            this.MainSkin = new FlatUI.FormSkin();
            this.lblDllNamespace = new FlatUI.FlatLabel();
            this.txtDllNamespace = new FlatUI.FlatTextBox();
            this.btnUpdate = new FlatUI.FlatButton();
            this.lblStatus = new FlatUI.FlatLabel();
            this.chkInjectUInject = new FlatUI.FlatCheckBox();
            this.btnFindDll = new FlatUI.FlatButton();
            this.lblInjectedDll = new FlatUI.FlatLabel();
            this.lblMonoApp = new FlatUI.FlatLabel();
            this.txtDllPath = new FlatUI.FlatTextBox();
            this.btnInject = new FlatUI.FlatButton();
            this.MonoAppList = new System.Windows.Forms.ListBox();
            this.flatClose1 = new FlatUI.FlatClose();
            this.MainSkin.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSkin
            // 
            this.MainSkin.BackColor = System.Drawing.Color.White;
            this.MainSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.MainSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.MainSkin.Controls.Add(this.lblDllNamespace);
            this.MainSkin.Controls.Add(this.txtDllNamespace);
            this.MainSkin.Controls.Add(this.btnUpdate);
            this.MainSkin.Controls.Add(this.lblStatus);
            this.MainSkin.Controls.Add(this.chkInjectUInject);
            this.MainSkin.Controls.Add(this.btnFindDll);
            this.MainSkin.Controls.Add(this.lblInjectedDll);
            this.MainSkin.Controls.Add(this.lblMonoApp);
            this.MainSkin.Controls.Add(this.txtDllPath);
            this.MainSkin.Controls.Add(this.btnInject);
            this.MainSkin.Controls.Add(this.MonoAppList);
            this.MainSkin.Controls.Add(this.flatClose1);
            this.MainSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MainSkin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MainSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.MainSkin.HeaderMaximize = false;
            this.MainSkin.Location = new System.Drawing.Point(0, 0);
            this.MainSkin.Name = "MainSkin";
            this.MainSkin.Size = new System.Drawing.Size(497, 240);
            this.MainSkin.TabIndex = 0;
            this.MainSkin.Text = "UInject";
            // 
            // lblDllNamespace
            // 
            this.lblDllNamespace.AutoSize = true;
            this.lblDllNamespace.BackColor = System.Drawing.Color.Transparent;
            this.lblDllNamespace.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDllNamespace.ForeColor = System.Drawing.Color.White;
            this.lblDllNamespace.Location = new System.Drawing.Point(251, 125);
            this.lblDllNamespace.Name = "lblDllNamespace";
            this.lblDllNamespace.Size = new System.Drawing.Size(89, 13);
            this.lblDllNamespace.TabIndex = 12;
            this.lblDllNamespace.Text = "DLL Namespace:";
            // 
            // txtDllNamespace
            // 
            this.txtDllNamespace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtDllNamespace.FocusOnHover = false;
            this.txtDllNamespace.Location = new System.Drawing.Point(254, 141);
            this.txtDllNamespace.MaxLength = 32767;
            this.txtDllNamespace.Multiline = false;
            this.txtDllNamespace.Name = "txtDllNamespace";
            this.txtDllNamespace.ReadOnly = false;
            this.txtDllNamespace.Size = new System.Drawing.Size(231, 29);
            this.txtDllNamespace.TabIndex = 11;
            this.txtDllNamespace.Text = "RoRCheat";
            this.txtDllNamespace.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDllNamespace.TextColor = System.Drawing.Color.White;
            this.txtDllNamespace.UseSystemPasswordChar = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(11, 185);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Rounded = false;
            this.btnUpdate.Size = new System.Drawing.Size(232, 29);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update List";
            this.btnUpdate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(12, 218);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status:";
            // 
            // chkInjectUInject
            // 
            this.chkInjectUInject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.chkInjectUInject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.chkInjectUInject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.chkInjectUInject.Checked = true;
            this.chkInjectUInject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkInjectUInject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkInjectUInject.ForeColor = System.Drawing.Color.White;
            this.chkInjectUInject.Location = new System.Drawing.Point(254, 90);
            this.chkInjectUInject.Name = "chkInjectUInject";
            this.chkInjectUInject.Options = FlatUI.FlatCheckBox._Options.Style2;
            this.chkInjectUInject.Size = new System.Drawing.Size(178, 22);
            this.chkInjectUInject.TabIndex = 8;
            this.chkInjectUInject.Text = "Load UInject Framework";
            // 
            // btnFindDll
            // 
            this.btnFindDll.BackColor = System.Drawing.Color.Transparent;
            this.btnFindDll.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnFindDll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindDll.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindDll.Location = new System.Drawing.Point(460, 51);
            this.btnFindDll.Name = "btnFindDll";
            this.btnFindDll.Rounded = false;
            this.btnFindDll.Size = new System.Drawing.Size(26, 29);
            this.btnFindDll.TabIndex = 7;
            this.btnFindDll.Text = "...";
            this.btnFindDll.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnFindDll.Click += new System.EventHandler(this.btnFindDll_Click);
            // 
            // lblInjectedDll
            // 
            this.lblInjectedDll.AutoSize = true;
            this.lblInjectedDll.BackColor = System.Drawing.Color.Transparent;
            this.lblInjectedDll.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblInjectedDll.ForeColor = System.Drawing.Color.White;
            this.lblInjectedDll.Location = new System.Drawing.Point(251, 35);
            this.lblInjectedDll.Name = "lblInjectedDll";
            this.lblInjectedDll.Size = new System.Drawing.Size(72, 13);
            this.lblInjectedDll.TabIndex = 6;
            this.lblInjectedDll.Text = "Injected DLL:";
            // 
            // lblMonoApp
            // 
            this.lblMonoApp.AutoSize = true;
            this.lblMonoApp.BackColor = System.Drawing.Color.Transparent;
            this.lblMonoApp.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMonoApp.ForeColor = System.Drawing.Color.White;
            this.lblMonoApp.Location = new System.Drawing.Point(8, 35);
            this.lblMonoApp.Name = "lblMonoApp";
            this.lblMonoApp.Size = new System.Drawing.Size(62, 13);
            this.lblMonoApp.TabIndex = 5;
            this.lblMonoApp.Text = "MonoApp:";
            // 
            // txtDllPath
            // 
            this.txtDllPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtDllPath.FocusOnHover = false;
            this.txtDllPath.Location = new System.Drawing.Point(254, 51);
            this.txtDllPath.MaxLength = 32767;
            this.txtDllPath.Multiline = false;
            this.txtDllPath.Name = "txtDllPath";
            this.txtDllPath.ReadOnly = false;
            this.txtDllPath.Size = new System.Drawing.Size(200, 29);
            this.txtDllPath.TabIndex = 4;
            this.txtDllPath.Text = "C:\\Users\\Korbin Ellis\\source\\repos\\UInject_RoR2\\UInject_RoR2\\bin\\Release\\UInject_" +
    "RoR2.dll";
            this.txtDllPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDllPath.TextColor = System.Drawing.Color.White;
            this.txtDllPath.UseSystemPasswordChar = false;
            // 
            // btnInject
            // 
            this.btnInject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInject.BackColor = System.Drawing.Color.Transparent;
            this.btnInject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnInject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInject.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnInject.Location = new System.Drawing.Point(254, 185);
            this.btnInject.Name = "btnInject";
            this.btnInject.Rounded = false;
            this.btnInject.Size = new System.Drawing.Size(232, 29);
            this.btnInject.TabIndex = 3;
            this.btnInject.Text = "Inject";
            this.btnInject.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // MonoAppList
            // 
            this.MonoAppList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.MonoAppList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MonoAppList.ForeColor = System.Drawing.Color.White;
            this.MonoAppList.FormattingEnabled = true;
            this.MonoAppList.ItemHeight = 17;
            this.MonoAppList.Location = new System.Drawing.Point(11, 51);
            this.MonoAppList.Name = "MonoAppList";
            this.MonoAppList.Size = new System.Drawing.Size(232, 119);
            this.MonoAppList.TabIndex = 2;
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(472, 6);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 0;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 240);
            this.Controls.Add(this.MainSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainSkin.ResumeLayout(false);
            this.MainSkin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin MainSkin;
        private FlatUI.FlatClose flatClose1;
        private System.Windows.Forms.ListBox MonoAppList;
        private FlatUI.FlatTextBox txtDllPath;
        private FlatUI.FlatButton btnInject;
        private FlatUI.FlatButton btnFindDll;
        private FlatUI.FlatLabel lblInjectedDll;
        private FlatUI.FlatLabel lblMonoApp;
        private FlatUI.FlatCheckBox chkInjectUInject;
        private FlatUI.FlatLabel lblStatus;
        private FlatUI.FlatButton btnUpdate;
        private FlatUI.FlatLabel lblDllNamespace;
        private FlatUI.FlatTextBox txtDllNamespace;
    }
}