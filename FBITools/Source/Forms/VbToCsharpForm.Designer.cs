namespace FBITools
{
    partial class VbToCsharpForm
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
            this.lblTitle = new FBITools.FlatLabelA();
            this.txtInput = new FBITools.FlatTextBoxA();
            this.btnConvert = new FBITools.FlatButtonA();
            this.btnCopyResult = new FBITools.FlatButtonA();
            this.btnClear = new FBITools.FlatButtonA();
            this.lblWarning = new FBITools.FlatLabelA();
            this.tblResult = new FBITools.FlatTableLayoutPanelA();
            this.txtOutput = new FBITools.FlatTextBoxA();
            this.tblMainContent.SuspendLayout();
            this.tblInput.SuspendLayout();
            this.tblResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMainContent
            // 
            this.tblMainContent.ColumnCount = 1;
            this.tblMainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainContent.Controls.Add(this.tblInput, 0, 0);
            this.tblMainContent.Controls.Add(this.tblResult, 0, 1);
            this.tblMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainContent.FillOnFormResize = true;
            this.tblMainContent.Location = new System.Drawing.Point(0, 0);
            this.tblMainContent.Name = "tblMainContent";
            this.tblMainContent.Padding = new System.Windows.Forms.Padding(1);
            this.tblMainContent.RowCount = 2;
            this.tblMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblMainContent.Size = new System.Drawing.Size(834, 494);
            this.tblMainContent.SizeOriginal = new System.Drawing.Size(834, 494);
            this.tblMainContent.TabIndex = 0;
            // 
            // tblInput
            // 
            this.tblInput.ColumnCount = 3;
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblInput.Controls.Add(this.lblTitle, 0, 0);
            this.tblInput.Controls.Add(this.txtInput, 0, 1);
            this.tblInput.Controls.Add(this.btnConvert, 0, 2);
            this.tblInput.Controls.Add(this.btnCopyResult, 1, 2);
            this.tblInput.Controls.Add(this.btnClear, 2, 2);
            this.tblInput.Controls.Add(this.lblWarning, 0, 3);
            this.tblInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInput.Location = new System.Drawing.Point(1, 1);
            this.tblInput.Name = "tblInput";
            this.tblInput.RowCount = 4;
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.Size = new System.Drawing.Size(832, 221);
            this.tblInput.SizeOriginal = new System.Drawing.Size(832, 221);
            this.tblInput.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.tblInput.SetColumnSpan(this.lblTitle, 3);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.lblTitle.ForeColorType = App.Core.Desktop.LabelType.primary;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(832, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "VB.NET To CSharp";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.tblInput.SetColumnSpan(this.txtInput, 3);
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.LabelText = "Input";
            this.txtInput.Location = new System.Drawing.Point(0, 38);
            this.txtInput.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txtInput.MaximumSize = new System.Drawing.Size(0, 0);
            this.txtInput.MaxLength = 0;
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Padding = new System.Windows.Forms.Padding(1);
            this.txtInput.PreviousText = "";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(832, 115);
            this.txtInput.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConvert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnConvert.FlatAppearance.BorderSize = 0;
            this.btnConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnConvert.Location = new System.Drawing.Point(0, 159);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(0, 4, 2, 2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(272, 34);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            // 
            // btnCopyResult
            // 
            this.btnCopyResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyResult.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnCopyResult.FlatAppearance.BorderSize = 0;
            this.btnCopyResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnCopyResult.Location = new System.Drawing.Point(276, 159);
            this.btnCopyResult.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.btnCopyResult.Name = "btnCopyResult";
            this.btnCopyResult.Size = new System.Drawing.Size(278, 34);
            this.btnCopyResult.TabIndex = 3;
            this.btnCopyResult.Text = "Copy Result";
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnClear.Location = new System.Drawing.Point(558, 159);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 4, 0, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(274, 34);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            // 
            // lblWarning
            // 
            this.tblInput.SetColumnSpan(this.lblWarning, 3);
            this.lblWarning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.lblWarning.ForeColorType = App.Core.Desktop.LabelType.primary;
            this.lblWarning.Location = new System.Drawing.Point(0, 197);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(832, 24);
            this.lblWarning.TabIndex = 5;
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tblResult
            // 
            this.tblResult.ColumnCount = 1;
            this.tblResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblResult.Controls.Add(this.txtOutput, 0, 0);
            this.tblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblResult.Location = new System.Drawing.Point(1, 222);
            this.tblResult.Name = "tblResult";
            this.tblResult.RowCount = 1;
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.Size = new System.Drawing.Size(832, 271);
            this.tblResult.SizeOriginal = new System.Drawing.Size(832, 271);
            this.tblResult.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.LabelText = "Output";
            this.txtOutput.Location = new System.Drawing.Point(0, 2);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txtOutput.MaximumSize = new System.Drawing.Size(0, 0);
            this.txtOutput.MaxLength = 0;
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Padding = new System.Windows.Forms.Padding(1);
            this.txtOutput.PreviousText = "";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(832, 270);
            this.txtOutput.TabIndex = 0;
            // 
            // VbToCsharpForm
            // 
            this.ClientSize = new System.Drawing.Size(834, 494);
            this.Controls.Add(this.tblMainContent);
            this.Name = "VbToCsharpForm";
            this.Text = "VbToCsharpForm";
            this.tblMainContent.ResumeLayout(false);
            this.tblMainContent.PerformLayout();
            this.tblInput.ResumeLayout(false);
            this.tblResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatLabelA lblTitle;
        internal FlatTextBoxA txtInput;
        private FlatTableLayoutPanelA tblMainContent;
        internal FlatButtonA btnConvert;
        internal FlatLabelA lblWarning;
        internal FlatTableLayoutPanelA tblInput;
        private FlatTableLayoutPanelA tblResult;
        internal FlatButtonA btnCopyResult;
        internal FlatButtonA btnClear;
        internal FlatTextBoxA txtOutput;
    }
}