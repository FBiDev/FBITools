namespace FBITools
{
    partial class MainContentForm
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
            this.pnlContentR = new FBITools.FlatPanelA();
            this.pnlContentRInside = new FBITools.FlatPanelA();
            this.pnlContentL = new FBITools.FlatPanelA();
            this.tblMenu = new FBITools.FlatTableLayoutPanelA();
            this.btnTabFileCopy = new FBITools.FlatButtonA();
            this.btnTabFileBackup = new FBITools.FlatButtonA();
            this.btnTabImageResize = new FBITools.FlatButtonA();
            this.btnVbCsharp = new FBITools.FlatButtonA();
            this.btnTabConfig = new FBITools.FlatButtonA();
            this.btnWiiUcetk = new FBITools.FlatButtonA();
            this.pnlContentR.SuspendLayout();
            this.pnlContentL.SuspendLayout();
            this.tblMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContentR
            // 
            this.pnlContentR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlContentR.BackColorType = App.Core.Desktop.PanelType.white;
            this.pnlContentR.Controls.Add(this.pnlContentRInside);
            this.pnlContentR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlContentR.Location = new System.Drawing.Point(124, 0);
            this.pnlContentR.Name = "pnlContentR";
            this.pnlContentR.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.pnlContentR.Size = new System.Drawing.Size(306, 262);
            this.pnlContentR.TabIndex = 3;
            // 
            // pnlContentRInside
            // 
            this.pnlContentRInside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentRInside.Location = new System.Drawing.Point(4, 0);
            this.pnlContentRInside.Name = "pnlContentRInside";
            this.pnlContentRInside.Size = new System.Drawing.Size(302, 262);
            // 
            // pnlContentL
            // 
            this.pnlContentL.Controls.Add(this.tblMenu);
            this.pnlContentL.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContentL.Location = new System.Drawing.Point(0, 0);
            this.pnlContentL.Name = "pnlContentL";
            this.pnlContentL.Size = new System.Drawing.Size(124, 262);
            this.pnlContentL.TabIndex = 2;
            // 
            // tblMenu
            // 
            this.tblMenu.ColumnCount = 1;
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMenu.Controls.Add(this.btnTabFileCopy, 0, 0);
            this.tblMenu.Controls.Add(this.btnTabFileBackup, 0, 1);
            this.tblMenu.Controls.Add(this.btnTabImageResize, 0, 2);
            this.tblMenu.Controls.Add(this.btnVbCsharp, 0, 3);
            this.tblMenu.Controls.Add(this.btnWiiUcetk, 0, 4);
            this.tblMenu.Controls.Add(this.btnTabConfig, 0, 5);
            this.tblMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMenu.Location = new System.Drawing.Point(0, 0);
            this.tblMenu.Name = "tblMenu";
            this.tblMenu.Padding = new System.Windows.Forms.Padding(1);
            this.tblMenu.RowCount = 6;
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMenu.Size = new System.Drawing.Size(124, 262);
            this.tblMenu.SizeOriginal = new System.Drawing.Size(124, 262);
            this.tblMenu.TabIndex = 5;
            // 
            // btnTabFileCopy
            // 
            this.btnTabFileCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTabFileCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnTabFileCopy.FlatAppearance.BorderSize = 0;
            this.btnTabFileCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnTabFileCopy.Location = new System.Drawing.Point(1, 1);
            this.btnTabFileCopy.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnTabFileCopy.Name = "btnTabFileCopy";
            this.btnTabFileCopy.Size = new System.Drawing.Size(122, 34);
            this.btnTabFileCopy.TabIndex = 0;
            this.btnTabFileCopy.Text = "File Copy";
            // 
            // btnTabFileBackup
            // 
            this.btnTabFileBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTabFileBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnTabFileBackup.FlatAppearance.BorderSize = 0;
            this.btnTabFileBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnTabFileBackup.Location = new System.Drawing.Point(1, 39);
            this.btnTabFileBackup.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnTabFileBackup.Name = "btnTabFileBackup";
            this.btnTabFileBackup.Size = new System.Drawing.Size(122, 34);
            this.btnTabFileBackup.TabIndex = 1;
            this.btnTabFileBackup.Text = "File Backup";
            // 
            // btnTabImageResize
            // 
            this.btnTabImageResize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTabImageResize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnTabImageResize.FlatAppearance.BorderSize = 0;
            this.btnTabImageResize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnTabImageResize.Location = new System.Drawing.Point(1, 77);
            this.btnTabImageResize.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnTabImageResize.Name = "btnTabImageResize";
            this.btnTabImageResize.Size = new System.Drawing.Size(122, 34);
            this.btnTabImageResize.TabIndex = 2;
            this.btnTabImageResize.Text = "Image Resize";
            // 
            // btnVbCsharp
            // 
            this.btnVbCsharp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVbCsharp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnVbCsharp.FlatAppearance.BorderSize = 0;
            this.btnVbCsharp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnVbCsharp.Location = new System.Drawing.Point(1, 115);
            this.btnVbCsharp.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnVbCsharp.Name = "btnVbCsharp";
            this.btnVbCsharp.Size = new System.Drawing.Size(122, 34);
            this.btnVbCsharp.TabIndex = 3;
            this.btnVbCsharp.Text = "VB to CSharp";
            // 
            // btnTabConfig
            // 
            this.btnTabConfig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTabConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnTabConfig.FlatAppearance.BorderSize = 0;
            this.btnTabConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnTabConfig.Location = new System.Drawing.Point(1, 227);
            this.btnTabConfig.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnTabConfig.Name = "btnTabConfig";
            this.btnTabConfig.Size = new System.Drawing.Size(122, 34);
            this.btnTabConfig.TabIndex = 4;
            this.btnTabConfig.Text = "Configurações";
            // 
            // btnWiiUcetk
            // 
            this.btnWiiUcetk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWiiUcetk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnWiiUcetk.FlatAppearance.BorderSize = 0;
            this.btnWiiUcetk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnWiiUcetk.Location = new System.Drawing.Point(1, 153);
            this.btnWiiUcetk.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnWiiUcetk.Name = "btnWiiUcetk";
            this.btnWiiUcetk.Size = new System.Drawing.Size(122, 34);
            this.btnWiiUcetk.TabIndex = 5;
            this.btnWiiUcetk.Text = "WiiU cetk";
            // 
            // MainContentForm
            // 
            this.ClientSize = new System.Drawing.Size(430, 262);
            this.Controls.Add(this.pnlContentR);
            this.Controls.Add(this.pnlContentL);
            this.Name = "MainContentForm";
            this.Text = "MainContentForm";
            this.pnlContentR.ResumeLayout(false);
            this.pnlContentL.ResumeLayout(false);
            this.pnlContentL.PerformLayout();
            this.tblMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal FlatPanelA pnlContentL;
        internal FlatButtonA btnTabFileCopy;
        internal FlatButtonA btnTabFileBackup;
        internal FlatPanelA pnlContentR;
        internal FlatPanelA pnlContentRInside;
        private FlatTableLayoutPanelA tblMenu;
        internal FlatButtonA btnTabConfig;
        internal FlatButtonA btnTabImageResize;
        internal FlatButtonA btnVbCsharp;
        internal FlatButtonA btnWiiUcetk;
    }
}