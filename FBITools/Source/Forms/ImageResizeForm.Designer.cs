namespace FBITools
{
    partial class ImageResizeForm
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
            this.picResized = new FBITools.FlatPictureBoxA();
            this.cboColorProfile = new FBITools.FlatComboBoxA();
            this.cboInterpolation = new FBITools.FlatComboBoxA();
            this.lblTitle = new FBITools.FlatLabelA();
            this.btnOrigin = new FBITools.FlatButtonA();
            this.txtOrigin = new FBITools.FlatTextBoxA();
            this.btnDestination = new FBITools.FlatButtonA();
            this.txtDestination = new FBITools.FlatTextBoxA();
            this.cboEncoder = new FBITools.FlatComboBoxA();
            this.cboResizeMode = new FBITools.FlatComboBoxA();
            this.picDrop = new FBITools.FlatPictureBoxA();
            this.tblResult = new FBITools.FlatTableLayoutPanelA();
            this.btnResize = new FBITools.FlatButtonA();
            this.lblWarning = new FBITools.FlatLabelA();
            this.tblMainContent.SuspendLayout();
            this.tblInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrop)).BeginInit();
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
            this.tblMainContent.RowCount = 3;
            this.tblMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainContent.Size = new System.Drawing.Size(430, 464);
            this.tblMainContent.SizeOriginal = new System.Drawing.Size(430, 428);
            this.tblMainContent.TabIndex = 0;
            // 
            // tblInput
            // 
            this.tblInput.ColumnCount = 4;
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblInput.Controls.Add(this.lblTitle, 0, 0);
            this.tblInput.Controls.Add(this.btnOrigin, 0, 1);
            this.tblInput.Controls.Add(this.txtOrigin, 1, 1);
            this.tblInput.Controls.Add(this.btnDestination, 0, 2);
            this.tblInput.Controls.Add(this.txtDestination, 1, 2);
            this.tblInput.Controls.Add(this.cboEncoder, 0, 3);
            this.tblInput.Controls.Add(this.cboResizeMode, 1, 3);
            this.tblInput.Controls.Add(this.cboInterpolation, 2, 3);
            this.tblInput.Controls.Add(this.cboColorProfile, 3, 3);
            this.tblInput.Location = new System.Drawing.Point(1, 1);
            this.tblInput.Name = "tblInput";
            this.tblInput.RowCount = 5;
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.Size = new System.Drawing.Size(428, 148);
            this.tblInput.SizeOriginal = new System.Drawing.Size(428, 256);
            this.tblInput.TabIndex = 0;
            // 
            // picResized
            // 
            this.picResized.AllowDrop = true;
            this.picResized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picResized.Filter = ((GNX.ImageFormats)(((GNX.ImageFormats.Jpg | GNX.ImageFormats.Jpeg) 
            | GNX.ImageFormats.Png)));
            this.picResized.Image = null;
            this.picResized.Location = new System.Drawing.Point(216, 70);
            this.picResized.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.picResized.Name = "picResized";
            this.picResized.Size = new System.Drawing.Size(212, 208);
            this.picResized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResized.TabIndex = 0;
            this.picResized.TabStop = false;
            // 
            // cboColorProfile
            // 
            this.cboColorProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboColorProfile.BackColor = System.Drawing.Color.White;
            this.cboColorProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboColorProfile.LabelText = "ColorProfile";
            this.cboColorProfile.Location = new System.Drawing.Point(320, 114);
            this.cboColorProfile.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.cboColorProfile.Name = "cboColorProfile";
            this.cboColorProfile.Size = new System.Drawing.Size(108, 34);
            this.cboColorProfile.TabIndex = 1;
            // 
            // cboInterpolation
            // 
            this.cboInterpolation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboInterpolation.BackColor = System.Drawing.Color.White;
            this.cboInterpolation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboInterpolation.LabelText = "Interpolation";
            this.cboInterpolation.Location = new System.Drawing.Point(212, 114);
            this.cboInterpolation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.cboInterpolation.Name = "cboInterpolation";
            this.cboInterpolation.Size = new System.Drawing.Size(104, 34);
            this.cboInterpolation.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.tblInput.SetColumnSpan(this.lblTitle, 4);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.lblTitle.ForeColorType = GNX.Desktop.LabelType.primary;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(428, 34);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "ImageResize";
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
            this.btnOrigin.Size = new System.Drawing.Size(100, 34);
            this.btnOrigin.TabIndex = 4;
            this.btnOrigin.Text = "Origin";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOrigin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.txtOrigin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtOrigin.BackgroundColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tblInput.SetColumnSpan(this.txtOrigin, 3);
            this.txtOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOrigin.Enabled = false;
            this.txtOrigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigin.LabelText = "File";
            this.txtOrigin.Location = new System.Drawing.Point(104, 38);
            this.txtOrigin.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.txtOrigin.MaximumSize = new System.Drawing.Size(0, 34);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Padding = new System.Windows.Forms.Padding(1);
            this.txtOrigin.PreviousText = "";
            this.txtOrigin.ReadOnly = true;
            this.txtOrigin.Size = new System.Drawing.Size(324, 34);
            this.txtOrigin.TabIndex = 5;
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
            this.btnDestination.Size = new System.Drawing.Size(100, 34);
            this.btnDestination.TabIndex = 6;
            this.btnDestination.Text = "Destination";
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.txtDestination.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDestination.BackgroundColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tblInput.SetColumnSpan(this.txtDestination, 3);
            this.txtDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDestination.Enabled = false;
            this.txtDestination.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination.LabelText = "File";
            this.txtDestination.Location = new System.Drawing.Point(104, 76);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.txtDestination.MaximumSize = new System.Drawing.Size(0, 34);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Padding = new System.Windows.Forms.Padding(1);
            this.txtDestination.PreviousText = "";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(324, 34);
            this.txtDestination.TabIndex = 7;
            // 
            // cboEncoder
            // 
            this.cboEncoder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboEncoder.BackColor = System.Drawing.Color.White;
            this.cboEncoder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboEncoder.LabelText = "Encoder";
            this.cboEncoder.Location = new System.Drawing.Point(0, 114);
            this.cboEncoder.Margin = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.cboEncoder.Name = "cboEncoder";
            this.cboEncoder.Size = new System.Drawing.Size(100, 34);
            this.cboEncoder.TabIndex = 8;
            // 
            // cboResizeMode
            // 
            this.cboResizeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboResizeMode.BackColor = System.Drawing.Color.White;
            this.cboResizeMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboResizeMode.LabelText = "ResizeMode";
            this.cboResizeMode.Location = new System.Drawing.Point(104, 114);
            this.cboResizeMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.cboResizeMode.Name = "cboResizeMode";
            this.cboResizeMode.Size = new System.Drawing.Size(104, 34);
            this.cboResizeMode.TabIndex = 9;
            // 
            // picDrop
            // 
            this.picDrop.AllowDrop = true;
            this.picDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDrop.Filter = ((GNX.ImageFormats)(((GNX.ImageFormats.Jpg | GNX.ImageFormats.Jpeg) 
            | GNX.ImageFormats.Png)));
            this.picDrop.Image = null;
            this.picDrop.Location = new System.Drawing.Point(0, 70);
            this.picDrop.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.picDrop.Name = "picDrop";
            this.picDrop.Size = new System.Drawing.Size(212, 208);
            this.picDrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDrop.TabIndex = 10;
            this.picDrop.TabStop = false;
            // 
            // tblResult
            // 
            this.tblResult.ColumnCount = 2;
            this.tblResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblResult.Controls.Add(this.btnResize, 0, 0);
            this.tblResult.Controls.Add(this.lblWarning, 0, 1);
            this.tblResult.Controls.Add(this.picDrop, 0, 2);
            this.tblResult.Controls.Add(this.picResized, 1, 2);
            this.tblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblResult.Location = new System.Drawing.Point(1, 149);
            this.tblResult.Name = "tblResult";
            this.tblResult.RowCount = 4;
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.Size = new System.Drawing.Size(428, 280);
            this.tblResult.SizeOriginal = new System.Drawing.Size(428, 66);
            this.tblResult.TabIndex = 1;
            // 
            // btnResize
            // 
            this.tblResult.SetColumnSpan(this.btnResize, 2);
            this.btnResize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnResize.FlatAppearance.BorderSize = 0;
            this.btnResize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnResize.Location = new System.Drawing.Point(0, 4);
            this.btnResize.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(428, 34);
            this.btnResize.TabIndex = 0;
            this.btnResize.Text = "Resize";
            // 
            // lblWarning
            // 
            this.tblResult.SetColumnSpan(this.lblWarning, 2);
            this.lblWarning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWarning.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarning.ForeColorType = GNX.Desktop.LabelType.danger;
            this.lblWarning.Location = new System.Drawing.Point(0, 42);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(428, 24);
            this.lblWarning.TabIndex = 1;
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ImageResizeForm
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(430, 464);
            this.Controls.Add(this.tblMainContent);
            this.Name = "ImageResizeForm";
            this.Text = "ImageResizeForm";
            this.tblMainContent.ResumeLayout(false);
            this.tblMainContent.PerformLayout();
            this.tblInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrop)).EndInit();
            this.tblResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatLabelA lblTitle;
        internal FlatButtonA btnDestination;
        internal FlatButtonA btnOrigin;
        internal FlatTextBoxA txtOrigin;
        internal FlatTextBoxA txtDestination;
        internal FlatButtonA btnResize;
        internal FlatLabelA lblWarning;
        private FlatTableLayoutPanelA tblMainContent;
        internal FlatComboBoxA cboEncoder;
        internal FlatComboBoxA cboResizeMode;
        internal FlatTableLayoutPanelA tblInput;
        private FlatTableLayoutPanelA tblResult;
        internal FlatPictureBoxA picDrop;
        internal FlatComboBoxA cboInterpolation;
        internal FlatComboBoxA cboColorProfile;
        internal FlatPictureBoxA picResized;
    }
}