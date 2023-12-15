namespace FBITools
{
    partial class SaveStateForm
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
            this.dlgOrigin = new System.Windows.Forms.OpenFileDialog();
            this.dlgDestination = new System.Windows.Forms.SaveFileDialog();
            this.tblMainContent = new FBITools.FlatTableLayoutPanelA();
            this.tblInput = new FBITools.FlatTableLayoutPanelA();
            this.lblTitle = new FBITools.FlatLabelA();
            this.btnOrigin = new FBITools.FlatButtonA();
            this.txtOrigin = new FBITools.FlatTextBoxA();
            this.btnDestination = new FBITools.FlatButtonA();
            this.txtDestination = new FBITools.FlatTextBoxA();
            this.btnCopy = new FBITools.FlatButtonA();
            this.lblWarning = new FBITools.FlatLabelA();
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
            this.tblMainContent.Size = new System.Drawing.Size(430, 262);
            this.tblMainContent.SizeOriginal = new System.Drawing.Size(430, 262);
            this.tblMainContent.TabIndex = 0;
            // 
            // tblInput
            // 
            this.tblInput.ColumnCount = 2;
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInput.Controls.Add(this.lblTitle, 0, 0);
            this.tblInput.Controls.Add(this.btnOrigin, 0, 1);
            this.tblInput.Controls.Add(this.txtOrigin, 1, 1);
            this.tblInput.Controls.Add(this.btnDestination, 0, 2);
            this.tblInput.Controls.Add(this.txtDestination, 1, 2);
            this.tblInput.Controls.Add(this.btnCopy, 0, 3);
            this.tblInput.Controls.Add(this.lblWarning, 0, 4);
            this.tblInput.Location = new System.Drawing.Point(1, 1);
            this.tblInput.Name = "tblInput";
            this.tblInput.RowCount = 4;
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.Size = new System.Drawing.Size(428, 176);
            this.tblInput.SizeOriginal = new System.Drawing.Size(428, 176);
            this.tblInput.TabIndex = 0;
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
            this.lblTitle.Size = new System.Drawing.Size(428, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SaveState";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOrigin
            // 
            this.btnOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrigin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnOrigin.FlatAppearance.BorderSize = 0;
            this.btnOrigin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnOrigin.Location = new System.Drawing.Point(0, 38);
            this.btnOrigin.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(80, 34);
            this.btnOrigin.TabIndex = 1;
            this.btnOrigin.Text = "Origin";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOrigin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.txtOrigin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtOrigin.BackgroundColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOrigin.Enabled = false;
            this.txtOrigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigin.LabelText = "File";
            this.txtOrigin.Location = new System.Drawing.Point(84, 38);
            this.txtOrigin.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.txtOrigin.MaximumSize = new System.Drawing.Size(0, 34);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Padding = new System.Windows.Forms.Padding(1);
            this.txtOrigin.PreviousText = "";
            this.txtOrigin.ReadOnly = true;
            this.txtOrigin.Size = new System.Drawing.Size(344, 34);
            this.txtOrigin.TabIndex = 2;
            // 
            // btnDestination
            // 
            this.btnDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDestination.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnDestination.FlatAppearance.BorderSize = 0;
            this.btnDestination.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnDestination.Location = new System.Drawing.Point(0, 76);
            this.btnDestination.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(80, 34);
            this.btnDestination.TabIndex = 3;
            this.btnDestination.Text = "Destination";
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.txtDestination.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDestination.BackgroundColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDestination.Enabled = false;
            this.txtDestination.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination.LabelText = "File";
            this.txtDestination.Location = new System.Drawing.Point(84, 76);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.txtDestination.MaximumSize = new System.Drawing.Size(0, 34);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Padding = new System.Windows.Forms.Padding(1);
            this.txtDestination.PreviousText = "";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(344, 34);
            this.txtDestination.TabIndex = 4;
            // 
            // btnCopy
            // 
            this.tblInput.SetColumnSpan(this.btnCopy, 2);
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnCopy.Location = new System.Drawing.Point(0, 114);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(428, 34);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            // 
            // lblWarning
            // 
            this.tblInput.SetColumnSpan(this.lblWarning, 2);
            this.lblWarning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWarning.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarning.ForeColorType = GNX.Desktop.LabelType.danger;
            this.lblWarning.Location = new System.Drawing.Point(0, 152);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(428, 24);
            this.lblWarning.TabIndex = 6;
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SaveStateForm
            // 
            this.ClientSize = new System.Drawing.Size(430, 262);
            this.Controls.Add(this.tblMainContent);
            this.Name = "SaveStateForm";
            this.Text = "SaveStateForm";
            this.tblMainContent.ResumeLayout(false);
            this.tblMainContent.PerformLayout();
            this.tblInput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatLabelA lblTitle;
        internal FlatButtonA btnDestination;
        internal FlatButtonA btnOrigin;
        internal FlatTextBoxA txtOrigin;
        internal FlatTextBoxA txtDestination;
        internal FlatButtonA btnCopy;
        internal FlatLabelA lblWarning;
        internal System.Windows.Forms.OpenFileDialog dlgOrigin;
        internal System.Windows.Forms.SaveFileDialog dlgDestination;
        private FlatTableLayoutPanelA tblInput;
        private FlatTableLayoutPanelA tblMainContent;
    }
}