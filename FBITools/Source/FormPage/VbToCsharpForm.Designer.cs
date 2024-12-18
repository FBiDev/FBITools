// <auto-generated/>
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
            this.InputTextBox = new FBITools.FlatTextBoxA();
            this.ConvertButton = new FBITools.FlatButtonA();
            this.CopyResultButton = new FBITools.FlatButtonA();
            this.ClearButton = new FBITools.FlatButtonA();
            this.WarningLabel = new FBITools.FlatLabelA();
            this.tblResult = new FBITools.FlatTableLayoutPanelA();
            this.OutputTextBox = new FBITools.FlatTextBoxA();
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
            this.tblInput.Controls.Add(this.InputTextBox, 0, 1);
            this.tblInput.Controls.Add(this.ConvertButton, 0, 2);
            this.tblInput.Controls.Add(this.CopyResultButton, 1, 2);
            this.tblInput.Controls.Add(this.ClearButton, 2, 2);
            this.tblInput.Controls.Add(this.WarningLabel, 0, 3);
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
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.InputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.tblInput.SetColumnSpan(this.InputTextBox, 3);
            this.InputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextBox.LabelText = "Input";
            this.InputTextBox.Location = new System.Drawing.Point(0, 38);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.InputTextBox.MaximumSize = new System.Drawing.Size(0, 0);
            this.InputTextBox.MaxLength = 0;
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "txtInput";
            this.InputTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.InputTextBox.PreviousText = "";
            this.InputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputTextBox.Size = new System.Drawing.Size(832, 115);
            this.InputTextBox.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.ConvertButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConvertButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.ConvertButton.FlatAppearance.BorderSize = 0;
            this.ConvertButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ConvertButton.Location = new System.Drawing.Point(0, 159);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(0, 4, 2, 2);
            this.ConvertButton.Name = "btnConvert";
            this.ConvertButton.Size = new System.Drawing.Size(272, 34);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Text = "Convert";
            // 
            // btnCopyResult
            // 
            this.CopyResultButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CopyResultButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.CopyResultButton.FlatAppearance.BorderSize = 0;
            this.CopyResultButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.CopyResultButton.Location = new System.Drawing.Point(276, 159);
            this.CopyResultButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.CopyResultButton.Name = "btnCopyResult";
            this.CopyResultButton.Size = new System.Drawing.Size(278, 34);
            this.CopyResultButton.TabIndex = 3;
            this.CopyResultButton.Text = "Copy Result";
            // 
            // btnClear
            // 
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ClearButton.Location = new System.Drawing.Point(558, 159);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2, 4, 0, 2);
            this.ClearButton.Name = "btnClear";
            this.ClearButton.Size = new System.Drawing.Size(274, 34);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            // 
            // lblWarning
            // 
            this.tblInput.SetColumnSpan(this.WarningLabel, 3);
            this.WarningLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.WarningLabel.ForeColorType = App.Core.Desktop.LabelType.primary;
            this.WarningLabel.Location = new System.Drawing.Point(0, 197);
            this.WarningLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.WarningLabel.Name = "lblWarning";
            this.WarningLabel.Size = new System.Drawing.Size(832, 24);
            this.WarningLabel.TabIndex = 5;
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tblResult
            // 
            this.tblResult.ColumnCount = 1;
            this.tblResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblResult.Controls.Add(this.OutputTextBox, 0, 0);
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
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.OutputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.OutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTextBox.LabelText = "Output";
            this.OutputTextBox.Location = new System.Drawing.Point(0, 2);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.OutputTextBox.MaximumSize = new System.Drawing.Size(0, 0);
            this.OutputTextBox.MaxLength = 0;
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "txtOutput";
            this.OutputTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.OutputTextBox.PreviousText = "";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputTextBox.Size = new System.Drawing.Size(832, 269);
            this.OutputTextBox.TabIndex = 0;
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
        internal FlatTextBoxA InputTextBox;
        private FlatTableLayoutPanelA tblMainContent;
        internal FlatButtonA ConvertButton;
        internal FlatLabelA WarningLabel;
        internal FlatTableLayoutPanelA tblInput;
        private FlatTableLayoutPanelA tblResult;
        internal FlatButtonA CopyResultButton;
        internal FlatButtonA ClearButton;
        internal FlatTextBoxA OutputTextBox;
    }
}