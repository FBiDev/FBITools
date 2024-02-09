namespace FBITools
{
    partial class ConfigForm
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
            this.tblMainContent = new FBITools.FlatTableLayoutPanelA();
            this.tblInput = new FBITools.FlatTableLayoutPanelA();
            this.chkAutoResizeWindow = new FBITools.FlatCheckBoxA();
            this.chkAutoCenterWindow = new FBITools.FlatCheckBoxA();
            this.lblTitle = new FBITools.FlatLabelA();
            this.chkDarkMode = new FBITools.FlatCheckBoxA();
            this.chkDebugMode = new FBITools.FlatCheckBoxA();
            this.tblMainContent.SuspendLayout();
            this.tblInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMainContent
            // 
            this.tblMainContent.ColumnCount = 1;
            this.tblMainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainContent.Controls.Add(this.tblInput, 0, 0);
            this.tblMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainContent.FillOnFormResize = true;
            this.tblMainContent.Location = new System.Drawing.Point(0, 0);
            this.tblMainContent.Name = "tblMainContent";
            this.tblMainContent.Padding = new System.Windows.Forms.Padding(1);
            this.tblMainContent.RowCount = 2;
            this.tblMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainContent.Size = new System.Drawing.Size(300, 262);
            this.tblMainContent.SizeOriginal = new System.Drawing.Size(300, 262);
            this.tblMainContent.TabIndex = 10;
            // 
            // tblInput
            // 
            this.tblInput.ColumnCount = 2;
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInput.Controls.Add(this.lblTitle, 0, 0);
            this.tblInput.Controls.Add(this.chkDarkMode, 0, 1);
            this.tblInput.Controls.Add(this.chkAutoCenterWindow, 0, 2);
            this.tblInput.Controls.Add(this.chkAutoResizeWindow, 0, 3);
            this.tblInput.Controls.Add(this.chkDebugMode, 0, 4);
            this.tblInput.Location = new System.Drawing.Point(1, 1);
            this.tblInput.Name = "tblInput";
            this.tblInput.RowCount = 5;
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.Size = new System.Drawing.Size(298, 186);
            this.tblInput.SizeOriginal = new System.Drawing.Size(298, 186);
            this.tblInput.TabIndex = 0;
            // 
            // chkAutoResizeWindow
            // 
            this.tblInput.SetColumnSpan(this.chkAutoResizeWindow, 2);
            this.chkAutoResizeWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAutoResizeWindow.Location = new System.Drawing.Point(0, 114);
            this.chkAutoResizeWindow.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.chkAutoResizeWindow.Name = "chkAutoResizeWindow";
            this.chkAutoResizeWindow.Size = new System.Drawing.Size(298, 34);
            this.chkAutoResizeWindow.TabIndex = 0;
            this.chkAutoResizeWindow.TextLegend = "AutoResize Window";
            // 
            // chkAutoCenterWindow
            // 
            this.tblInput.SetColumnSpan(this.chkAutoCenterWindow, 2);
            this.chkAutoCenterWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAutoCenterWindow.Location = new System.Drawing.Point(0, 76);
            this.chkAutoCenterWindow.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.chkAutoCenterWindow.Name = "chkAutoCenterWindow";
            this.chkAutoCenterWindow.Size = new System.Drawing.Size(298, 34);
            this.chkAutoCenterWindow.TabIndex = 1;
            this.chkAutoCenterWindow.TextLegend = "AutoCenter Window";
            // 
            // lblTitle
            // 
            this.tblInput.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.lblTitle.ForeColorType = GNX.Desktop.LabelType.primary;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 34);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Configurações";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkDarkMode
            // 
            this.tblInput.SetColumnSpan(this.chkDarkMode, 2);
            this.chkDarkMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDarkMode.Location = new System.Drawing.Point(0, 38);
            this.chkDarkMode.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(298, 34);
            this.chkDarkMode.TabIndex = 3;
            this.chkDarkMode.TextLegend = "Dark Mode";
            // 
            // chkDebugMode
            // 
            this.tblInput.SetColumnSpan(this.chkDebugMode, 2);
            this.chkDebugMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDebugMode.Location = new System.Drawing.Point(0, 152);
            this.chkDebugMode.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.chkDebugMode.Name = "chkDebugMode";
            this.chkDebugMode.Size = new System.Drawing.Size(298, 34);
            this.chkDebugMode.TabIndex = 4;
            this.chkDebugMode.TextLegend = "Debug Mode";
            // 
            // ConfigForm
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(300, 262);
            this.Controls.Add(this.tblMainContent);
            this.Name = "ConfigForm";
            this.Text = "SolicitacaoForm";
            this.tblMainContent.ResumeLayout(false);
            this.tblMainContent.PerformLayout();
            this.tblInput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatLabelA lblTitle;
        internal FlatTableLayoutPanelA tblInput;
        private FlatTableLayoutPanelA tblMainContent;
        internal FlatCheckBoxA chkDarkMode;
        internal FlatCheckBoxA chkDebugMode;
        internal FlatCheckBoxA chkAutoResizeWindow;
        internal FlatCheckBoxA chkAutoCenterWindow;

    }
}