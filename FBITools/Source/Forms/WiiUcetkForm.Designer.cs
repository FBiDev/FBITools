namespace FBITools
{
    partial class WiiUcetkForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblMainContent = new FBITools.FlatTableLayoutPanelA();
            this.tblInput = new FBITools.FlatTableLayoutPanelA();
            this.lblTitle = new FBITools.FlatLabelA();
            this.txtTitleID = new FBITools.FlatMaskedTextBoxA();
            this.txtTitleName = new FBITools.FlatTextBoxA();
            this.chkListRegion = new FBITools.FlatCheckedListA();
            this.chkListCategory = new FBITools.FlatCheckedListA();
            this.btnGenerateCetk = new FBITools.FlatButtonA();
            this.lblWarning = new FBITools.FlatLabelA();
            this.tblResult = new FBITools.FlatTableLayoutPanelA();
            this.dgvTitles = new FBITools.FlatDataGridA();
            this.staTitles = new FBITools.FlatStatusBarA();
            this.tblMainContent.SuspendLayout();
            this.tblInput.SuspendLayout();
            this.tblResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitles)).BeginInit();
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
            this.tblMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainContent.Size = new System.Drawing.Size(704, 624);
            this.tblMainContent.SizeOriginal = new System.Drawing.Size(704, 624);
            this.tblMainContent.TabIndex = 0;
            // 
            // tblInput
            // 
            this.tblInput.ColumnCount = 3;
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblInput.Controls.Add(this.lblTitle, 0, 0);
            this.tblInput.Controls.Add(this.txtTitleID, 0, 1);
            this.tblInput.Controls.Add(this.txtTitleName, 0, 2);
            this.tblInput.Controls.Add(this.chkListRegion, 1, 1);
            this.tblInput.Controls.Add(this.chkListCategory, 2, 1);
            this.tblInput.Controls.Add(this.btnGenerateCetk, 0, 3);
            this.tblInput.Controls.Add(this.lblWarning, 0, 4);
            this.tblInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInput.Location = new System.Drawing.Point(1, 1);
            this.tblInput.Name = "tblInput";
            this.tblInput.RowCount = 5;
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInput.Size = new System.Drawing.Size(702, 194);
            this.tblInput.SizeOriginal = new System.Drawing.Size(702, 194);
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
            this.lblTitle.Size = new System.Drawing.Size(702, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WiiU cetk Generator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitleID
            // 
            this.txtTitleID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitleID.LabelText = "Title ID";
            this.txtTitleID.Location = new System.Drawing.Point(0, 38);
            this.txtTitleID.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.txtTitleID.Mask = App.Core.Desktop.TextMask.None;
            this.txtTitleID.MaxLength = 16;
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(349, 34);
            this.txtTitleID.TabIndex = 1;
            this.txtTitleID.TextAlign = App.Core.Desktop.FlatMaskedTextBox.TextAlignTypes.Left;
            // 
            // txtTitleName
            // 
            this.txtTitleName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTitleName.LabelText = "Title Name";
            this.txtTitleName.Location = new System.Drawing.Point(0, 94);
            this.txtTitleName.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.txtTitleName.MaxLength = 0;
            this.txtTitleName.Name = "txtTitleName";
            this.txtTitleName.PreviousText = "";
            this.txtTitleName.Size = new System.Drawing.Size(349, 34);
            this.txtTitleName.TabIndex = 2;
            // 
            // chkListRegion
            // 
            this.chkListRegion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListRegion.Location = new System.Drawing.Point(353, 38);
            this.chkListRegion.Name = "chkListRegion";
            this.tblInput.SetRowSpan(this.chkListRegion, 2);
            this.chkListRegion.Size = new System.Drawing.Size(171, 90);
            this.chkListRegion.TabIndex = 3;
            this.chkListRegion.TextLegend = "Region";
            // 
            // chkListCategory
            // 
            this.chkListCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListCategory.Location = new System.Drawing.Point(528, 38);
            this.chkListCategory.Name = "chkListCategory";
            this.tblInput.SetRowSpan(this.chkListCategory, 2);
            this.chkListCategory.Size = new System.Drawing.Size(172, 90);
            this.chkListCategory.TabIndex = 4;
            this.chkListCategory.TextLegend = "Category";
            // 
            // btnGenerateCetk
            // 
            this.tblInput.SetColumnSpan(this.btnGenerateCetk, 3);
            this.btnGenerateCetk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerateCetk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnGenerateCetk.FlatAppearance.BorderSize = 0;
            this.btnGenerateCetk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnGenerateCetk.Location = new System.Drawing.Point(0, 132);
            this.btnGenerateCetk.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnGenerateCetk.Name = "btnGenerateCetk";
            this.btnGenerateCetk.Size = new System.Drawing.Size(702, 34);
            this.btnGenerateCetk.TabIndex = 5;
            this.btnGenerateCetk.Text = "Generate cetk";
            // 
            // lblWarning
            // 
            this.tblInput.SetColumnSpan(this.lblWarning, 3);
            this.lblWarning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.lblWarning.ForeColorType = App.Core.Desktop.LabelType.primary;
            this.lblWarning.Location = new System.Drawing.Point(0, 170);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(702, 24);
            this.lblWarning.TabIndex = 6;
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tblResult
            // 
            this.tblResult.ColumnCount = 1;
            this.tblResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblResult.Controls.Add(this.dgvTitles, 0, 0);
            this.tblResult.Controls.Add(this.staTitles, 0, 1);
            this.tblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblResult.Location = new System.Drawing.Point(1, 195);
            this.tblResult.Name = "tblResult";
            this.tblResult.RowCount = 2;
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblResult.Size = new System.Drawing.Size(702, 428);
            this.tblResult.SizeOriginal = new System.Drawing.Size(702, 428);
            this.tblResult.TabIndex = 1;
            // 
            // dgvTitles
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTitles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTitles.ColorBackground = System.Drawing.Color.White;
            this.dgvTitles.ColorColumnHeader = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.dgvTitles.ColorColumnHeaderMouseHover = System.Drawing.Color.Empty;
            this.dgvTitles.ColorColumnHeaderReorderDiv = System.Drawing.Color.Empty;
            this.dgvTitles.ColorColumnHeaderReorderRec = System.Drawing.Color.Empty;
            this.dgvTitles.ColorColumnSelection = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.dgvTitles.ColorFontRow = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvTitles.ColorFontRowSelection = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvTitles.ColorGrid = System.Drawing.Color.Silver;
            this.dgvTitles.ColorRow = System.Drawing.Color.White;
            this.dgvTitles.ColorRowAlternate = System.Drawing.Color.White;
            this.dgvTitles.ColorRowMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.dgvTitles.ColorRowSelection = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTitles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTitles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTitles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTitles.Location = new System.Drawing.Point(0, 2);
            this.dgvTitles.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.dgvTitles.Name = "dgvTitles";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTitles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTitles.RowTemplate.Height = 30;
            this.dgvTitles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTitles.Size = new System.Drawing.Size(702, 397);
            this.dgvTitles.StandardTab = true;
            this.dgvTitles.TabIndex = 0;
            this.dgvTitles.TabStop = true;
            // 
            // staTitles
            // 
            this.staTitles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.staTitles.BackColorContent = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.staTitles.BorderEnable = true;
            this.staTitles.Dock = System.Windows.Forms.DockStyle.Top;
            this.staTitles.Location = new System.Drawing.Point(3, 402);
            this.staTitles.Movimento = App.Core.Desktop.Movimento.Nenhum;
            this.staTitles.Name = "staTitles";
            this.staTitles.Registros = null;
            this.staTitles.Size = new System.Drawing.Size(696, 23);
            this.staTitles.TabIndex = 1;
            // 
            // WiiUcetkForm
            // 
            this.ClientSize = new System.Drawing.Size(704, 624);
            this.Controls.Add(this.tblMainContent);
            this.Name = "WiiUcetkForm";
            this.Text = "WiiUcetkForm";
            this.tblMainContent.ResumeLayout(false);
            this.tblMainContent.PerformLayout();
            this.tblInput.ResumeLayout(false);
            this.tblResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatLabelA lblTitle;
        internal FlatMaskedTextBoxA txtTitleID;
        private FlatTableLayoutPanelA tblMainContent;
        internal FlatButtonA btnGenerateCetk;
        internal FlatLabelA lblWarning;
        internal FlatTableLayoutPanelA tblInput;
        private FlatTableLayoutPanelA tblResult;
        internal FlatTextBoxA txtTitleName;
        internal FlatDataGridA dgvTitles;
        internal FlatCheckedListA chkListRegion;
        internal FlatCheckedListA chkListCategory;
        internal FlatStatusBarA staTitles;
    }
}