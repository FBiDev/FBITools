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
            this.lblTitle = new FBITools.FlatLabelA();
            this.btnOrigin = new FBITools.FlatButtonA();
            this.txtOrigin = new FBITools.FlatTextBoxA();
            this.btnDestination = new FBITools.FlatButtonA();
            this.txtDestination = new FBITools.FlatTextBoxA();
            this.cboEncoder = new FBITools.FlatComboBoxA();
            this.cboResizeMode = new FBITools.FlatComboBoxA();
            this.cboSizes = new FBITools.FlatComboBoxA();
            this.cboAnchor = new FBITools.FlatComboBoxA();
            this.cboInterpolation = new FBITools.FlatComboBoxA();
            this.cboMatteColor = new FBITools.FlatComboBoxA();
            this.cboColorProfile = new FBITools.FlatComboBoxA();
            this.cboSharpen = new FBITools.FlatComboBoxA();
            this.cboBlendingMode = new FBITools.FlatComboBoxA();
            this.cboHybridMode = new FBITools.FlatComboBoxA();
            this.lblPNG = new FBITools.FlatLabelA();
            this.cboPngFilter = new FBITools.FlatComboBoxA();
            this.cboPngInterlace = new FBITools.FlatComboBoxA();
            this.lblJPG = new FBITools.FlatLabelA();
            this.cboJpgQuality = new FBITools.FlatComboBoxA();
            this.cboJpgChromaSubsample = new FBITools.FlatComboBoxA();
            this.tblResult = new FBITools.FlatTableLayoutPanelA();
            this.btnResize = new FBITools.FlatButtonA();
            this.lblWarning = new FBITools.FlatLabelA();
            this.picDrop = new FBITools.FlatPictureBoxA();
            this.picResized = new FBITools.FlatPictureBoxA();
            this.tblMainContent.SuspendLayout();
            this.tblInput.SuspendLayout();
            this.tblResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResized)).BeginInit();
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
            this.tblMainContent.Size = new System.Drawing.Size(465, 656);
            this.tblMainContent.SizeOriginal = new System.Drawing.Size(465, 656);
            this.tblMainContent.TabIndex = 0;
            // 
            // tblInput
            // 
            this.tblInput.ColumnCount = 3;
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInput.Controls.Add(this.lblTitle, 0, 0);
            this.tblInput.Controls.Add(this.btnOrigin, 0, 1);
            this.tblInput.Controls.Add(this.txtOrigin, 1, 1);
            this.tblInput.Controls.Add(this.btnDestination, 0, 2);
            this.tblInput.Controls.Add(this.txtDestination, 1, 2);
            this.tblInput.Controls.Add(this.cboEncoder, 0, 3);
            this.tblInput.Controls.Add(this.cboResizeMode, 1, 3);
            this.tblInput.Controls.Add(this.cboSizes, 2, 3);
            this.tblInput.Controls.Add(this.cboAnchor, 0, 4);
            this.tblInput.Controls.Add(this.cboInterpolation, 2, 4);
            this.tblInput.Controls.Add(this.cboMatteColor, 0, 5);
            this.tblInput.Controls.Add(this.cboColorProfile, 2, 5);
            this.tblInput.Controls.Add(this.cboSharpen, 0, 6);
            this.tblInput.Controls.Add(this.cboBlendingMode, 1, 6);
            this.tblInput.Controls.Add(this.cboHybridMode, 2, 6);
            this.tblInput.Controls.Add(this.lblPNG, 0, 7);
            this.tblInput.Controls.Add(this.cboPngFilter, 1, 7);
            this.tblInput.Controls.Add(this.cboPngInterlace, 2, 7);
            this.tblInput.Controls.Add(this.lblJPG, 0, 8);
            this.tblInput.Controls.Add(this.cboJpgQuality, 1, 8);
            this.tblInput.Controls.Add(this.cboJpgChromaSubsample, 2, 8);
            this.tblInput.Location = new System.Drawing.Point(1, 1);
            this.tblInput.Name = "tblInput";
            this.tblInput.RowCount = 9;
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.Size = new System.Drawing.Size(463, 356);
            this.tblInput.SizeOriginal = new System.Drawing.Size(463, 356);
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
            this.lblTitle.Size = new System.Drawing.Size(463, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Image Resize";
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
            this.btnOrigin.TabIndex = 1;
            this.btnOrigin.Text = "Origin";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOrigin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.txtOrigin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtOrigin.BackgroundColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tblInput.SetColumnSpan(this.txtOrigin, 2);
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
            this.txtOrigin.Size = new System.Drawing.Size(359, 34);
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
            this.btnDestination.Size = new System.Drawing.Size(100, 34);
            this.btnDestination.TabIndex = 3;
            this.btnDestination.Text = "Destination";
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.txtDestination.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDestination.BackgroundColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tblInput.SetColumnSpan(this.txtDestination, 2);
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
            this.txtDestination.Size = new System.Drawing.Size(359, 34);
            this.txtDestination.TabIndex = 4;
            // 
            // cboEncoder
            // 
            this.cboEncoder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboEncoder.BackColor = System.Drawing.Color.White;
            this.cboEncoder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboEncoder.LabelText = "Encoder";
            this.cboEncoder.Location = new System.Drawing.Point(0, 114);
            this.cboEncoder.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.cboEncoder.Name = "cboEncoder";
            this.cboEncoder.Size = new System.Drawing.Size(100, 34);
            this.cboEncoder.TabIndex = 5;
            // 
            // cboResizeMode
            // 
            this.cboResizeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboResizeMode.BackColor = System.Drawing.Color.White;
            this.cboResizeMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboResizeMode.LabelText = "ResizeMode";
            this.cboResizeMode.Location = new System.Drawing.Point(104, 114);
            this.cboResizeMode.Name = "cboResizeMode";
            this.cboResizeMode.Size = new System.Drawing.Size(176, 34);
            this.cboResizeMode.TabIndex = 6;
            // 
            // cboSizes
            // 
            this.cboSizes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboSizes.BackColor = System.Drawing.Color.White;
            this.cboSizes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSizes.LabelText = "Size";
            this.cboSizes.Location = new System.Drawing.Point(284, 114);
            this.cboSizes.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.cboSizes.Name = "cboSizes";
            this.cboSizes.Size = new System.Drawing.Size(179, 34);
            this.cboSizes.TabIndex = 7;
            // 
            // cboAnchor
            // 
            this.cboAnchor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboAnchor.BackColor = System.Drawing.Color.White;
            this.tblInput.SetColumnSpan(this.cboAnchor, 2);
            this.cboAnchor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboAnchor.LabelText = "Anchor";
            this.cboAnchor.Location = new System.Drawing.Point(0, 152);
            this.cboAnchor.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.cboAnchor.Name = "cboAnchor";
            this.cboAnchor.Size = new System.Drawing.Size(280, 34);
            this.cboAnchor.TabIndex = 8;
            // 
            // cboInterpolation
            // 
            this.cboInterpolation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboInterpolation.BackColor = System.Drawing.Color.White;
            this.cboInterpolation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboInterpolation.LabelText = "Interpolation";
            this.cboInterpolation.Location = new System.Drawing.Point(284, 152);
            this.cboInterpolation.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.cboInterpolation.Name = "cboInterpolation";
            this.cboInterpolation.Size = new System.Drawing.Size(179, 34);
            this.cboInterpolation.TabIndex = 9;
            // 
            // cboMatteColor
            // 
            this.cboMatteColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboMatteColor.BackColor = System.Drawing.Color.White;
            this.tblInput.SetColumnSpan(this.cboMatteColor, 2);
            this.cboMatteColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMatteColor.LabelText = "MatteColor";
            this.cboMatteColor.Location = new System.Drawing.Point(0, 190);
            this.cboMatteColor.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.cboMatteColor.Name = "cboMatteColor";
            this.cboMatteColor.Size = new System.Drawing.Size(280, 34);
            this.cboMatteColor.TabIndex = 10;
            // 
            // cboColorProfile
            // 
            this.cboColorProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboColorProfile.BackColor = System.Drawing.Color.White;
            this.cboColorProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboColorProfile.LabelText = "ColorProfile";
            this.cboColorProfile.Location = new System.Drawing.Point(284, 190);
            this.cboColorProfile.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.cboColorProfile.Name = "cboColorProfile";
            this.cboColorProfile.Size = new System.Drawing.Size(179, 34);
            this.cboColorProfile.TabIndex = 11;
            // 
            // cboSharpen
            // 
            this.cboSharpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboSharpen.BackColor = System.Drawing.Color.White;
            this.cboSharpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSharpen.LabelText = "Sharpen";
            this.cboSharpen.Location = new System.Drawing.Point(0, 228);
            this.cboSharpen.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.cboSharpen.Name = "cboSharpen";
            this.cboSharpen.Size = new System.Drawing.Size(100, 34);
            this.cboSharpen.TabIndex = 12;
            // 
            // cboBlendingMode
            // 
            this.cboBlendingMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboBlendingMode.BackColor = System.Drawing.Color.White;
            this.cboBlendingMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboBlendingMode.LabelText = "BlendingMode";
            this.cboBlendingMode.Location = new System.Drawing.Point(104, 228);
            this.cboBlendingMode.Name = "cboBlendingMode";
            this.cboBlendingMode.Size = new System.Drawing.Size(176, 34);
            this.cboBlendingMode.TabIndex = 13;
            // 
            // cboHybridMode
            // 
            this.cboHybridMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboHybridMode.BackColor = System.Drawing.Color.White;
            this.cboHybridMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboHybridMode.LabelText = "HybridMode";
            this.cboHybridMode.Location = new System.Drawing.Point(284, 228);
            this.cboHybridMode.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.cboHybridMode.Name = "cboHybridMode";
            this.cboHybridMode.Size = new System.Drawing.Size(179, 34);
            this.cboHybridMode.TabIndex = 14;
            // 
            // lblPNG
            // 
            this.lblPNG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPNG.Location = new System.Drawing.Point(0, 284);
            this.lblPNG.Margin = new System.Windows.Forms.Padding(0, 20, 2, 2);
            this.lblPNG.Name = "lblPNG";
            this.lblPNG.Size = new System.Drawing.Size(100, 34);
            this.lblPNG.TabIndex = 15;
            this.lblPNG.Text = "Png";
            this.lblPNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboPngFilter
            // 
            this.cboPngFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboPngFilter.BackColor = System.Drawing.Color.White;
            this.cboPngFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPngFilter.LabelText = "Filter";
            this.cboPngFilter.Location = new System.Drawing.Point(104, 284);
            this.cboPngFilter.Margin = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.cboPngFilter.Name = "cboPngFilter";
            this.cboPngFilter.Size = new System.Drawing.Size(176, 34);
            this.cboPngFilter.TabIndex = 16;
            // 
            // cboPngInterlace
            // 
            this.cboPngInterlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboPngInterlace.BackColor = System.Drawing.Color.White;
            this.cboPngInterlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPngInterlace.LabelText = "Interlace";
            this.cboPngInterlace.Location = new System.Drawing.Point(284, 284);
            this.cboPngInterlace.Margin = new System.Windows.Forms.Padding(2, 20, 0, 2);
            this.cboPngInterlace.Name = "cboPngInterlace";
            this.cboPngInterlace.Size = new System.Drawing.Size(179, 34);
            this.cboPngInterlace.TabIndex = 17;
            // 
            // lblJPG
            // 
            this.lblJPG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJPG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJPG.Location = new System.Drawing.Point(0, 322);
            this.lblJPG.Margin = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.lblJPG.Name = "lblJPG";
            this.lblJPG.Size = new System.Drawing.Size(100, 34);
            this.lblJPG.TabIndex = 18;
            this.lblJPG.Text = "Jpg";
            this.lblJPG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboJpgQuality
            // 
            this.cboJpgQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboJpgQuality.BackColor = System.Drawing.Color.White;
            this.cboJpgQuality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboJpgQuality.LabelText = "Quality";
            this.cboJpgQuality.Location = new System.Drawing.Point(104, 322);
            this.cboJpgQuality.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.cboJpgQuality.Name = "cboJpgQuality";
            this.cboJpgQuality.Size = new System.Drawing.Size(176, 34);
            this.cboJpgQuality.TabIndex = 19;
            // 
            // cboJpgChromaSubsample
            // 
            this.cboJpgChromaSubsample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboJpgChromaSubsample.BackColor = System.Drawing.Color.White;
            this.cboJpgChromaSubsample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboJpgChromaSubsample.LabelText = "ChromaSubsample";
            this.cboJpgChromaSubsample.Location = new System.Drawing.Point(284, 322);
            this.cboJpgChromaSubsample.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.cboJpgChromaSubsample.Name = "cboJpgChromaSubsample";
            this.cboJpgChromaSubsample.Size = new System.Drawing.Size(179, 34);
            this.cboJpgChromaSubsample.TabIndex = 20;
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
            this.tblResult.Location = new System.Drawing.Point(1, 357);
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
            this.tblResult.Size = new System.Drawing.Size(463, 280);
            this.tblResult.SizeOriginal = new System.Drawing.Size(463, 280);
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
            this.btnResize.Size = new System.Drawing.Size(463, 34);
            this.btnResize.TabIndex = 0;
            this.btnResize.Text = "Resize";
            // 
            // lblWarning
            // 
            this.tblResult.SetColumnSpan(this.lblWarning, 2);
            this.lblWarning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWarning.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarning.ForeColorType = App.Core.Desktop.LabelType.danger;
            this.lblWarning.Location = new System.Drawing.Point(0, 42);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(463, 24);
            this.lblWarning.TabIndex = 1;
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picDrop
            // 
            this.picDrop.AllowDrop = true;
            this.picDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDrop.Filter = ((App.Core.ImageFormats)(((App.Core.ImageFormats.Jpg | App.Core.ImageFormats.Jpeg) 
            | App.Core.ImageFormats.Png)));
            this.picDrop.Image = null;
            this.picDrop.Location = new System.Drawing.Point(0, 70);
            this.picDrop.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.picDrop.Name = "picDrop";
            this.picDrop.Size = new System.Drawing.Size(229, 208);
            this.picDrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDrop.TabIndex = 2;
            this.picDrop.TabStop = false;
            // 
            // picResized
            // 
            this.picResized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picResized.Filter = ((App.Core.ImageFormats)(((App.Core.ImageFormats.Jpg | App.Core.ImageFormats.Jpeg) 
            | App.Core.ImageFormats.Png)));
            this.picResized.Image = null;
            this.picResized.Location = new System.Drawing.Point(233, 70);
            this.picResized.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.picResized.Name = "picResized";
            this.picResized.Size = new System.Drawing.Size(230, 208);
            this.picResized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResized.TabIndex = 3;
            this.picResized.TabStop = false;
            // 
            // ImageResizeForm
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(465, 656);
            this.Controls.Add(this.tblMainContent);
            this.Name = "ImageResizeForm";
            this.Text = "ImageResizeForm";
            this.tblMainContent.ResumeLayout(false);
            this.tblMainContent.PerformLayout();
            this.tblInput.ResumeLayout(false);
            this.tblResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResized)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal FlatButtonA btnDestination;
        internal FlatButtonA btnOrigin;
        internal FlatTextBoxA txtOrigin;
        internal FlatTextBoxA txtDestination;
        internal FlatButtonA btnResize;
        internal FlatLabelA lblWarning;
        private FlatTableLayoutPanelA tblMainContent;
        internal FlatTableLayoutPanelA tblInput;
        private FlatTableLayoutPanelA tblResult;
        internal FlatPictureBoxA picDrop;
        internal FlatPictureBoxA picResized;
        internal FlatComboBoxA cboSizes;
        private FlatLabelA lblTitle;
        internal FlatComboBoxA cboEncoder;
        internal FlatComboBoxA cboResizeMode;
        internal FlatComboBoxA cboInterpolation;
        internal FlatComboBoxA cboColorProfile;
        internal FlatComboBoxA cboAnchor;
        internal FlatComboBoxA cboMatteColor;
        internal FlatComboBoxA cboSharpen;
        internal FlatComboBoxA cboBlendingMode;
        internal FlatComboBoxA cboHybridMode;
        internal FlatComboBoxA cboPngFilter;
        internal FlatComboBoxA cboPngInterlace;
        private FlatLabelA lblPNG;
        private FlatLabelA lblJPG;
        internal FlatComboBoxA cboJpgQuality;
        internal FlatComboBoxA cboJpgChromaSubsample;
    }
}