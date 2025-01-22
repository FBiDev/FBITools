// <auto-generated/>
namespace FBITools.WiiU
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
            this.MainContentTable = new FBITools.FlatTableA();
            this.InputTable = new FBITools.FlatTableA();
            this.TitleLabel = new FBITools.FlatLabelA();
            this.TitleIDTextBox = new FBITools.FlatMaskedTextBoxA();
            this.TitleNameTextBox = new FBITools.FlatTextBoxA();
            this.RegionCheckedList = new FBITools.FlatCheckedListA();
            this.CategoryCheckedList = new FBITools.FlatCheckedListA();
            this.GenerateCetkButton = new FBITools.FlatButtonA();
            this.WarningLabel = new FBITools.FlatLabelA();
            this.ResultTable = new FBITools.FlatTableA();
            this.TitlesGrid = new FBITools.FlatDataGridA();
            this.TitlesStatusBar = new FBITools.FlatStatusBarA();
            this.MainContentTable.SuspendLayout();
            this.InputTable.SuspendLayout();
            this.ResultTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainContentTable
            // 
            this.MainContentTable.ColumnCount = 1;
            this.MainContentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainContentTable.Controls.Add(this.InputTable, 0, 0);
            this.MainContentTable.Controls.Add(this.ResultTable, 0, 1);
            this.MainContentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentTable.FillOnFormResize = true;
            this.MainContentTable.Location = new System.Drawing.Point(0, 0);
            this.MainContentTable.Name = "MainContentTable";
            this.MainContentTable.Padding = new System.Windows.Forms.Padding(1);
            this.MainContentTable.RowCount = 2;
            this.MainContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainContentTable.Size = new System.Drawing.Size(704, 624);
            this.MainContentTable.SizeOriginal = new System.Drawing.Size(704, 624);
            this.MainContentTable.TabIndex = 0;
            // 
            // InputTable
            // 
            this.InputTable.ColumnCount = 3;
            this.InputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InputTable.Controls.Add(this.TitleLabel, 0, 0);
            this.InputTable.Controls.Add(this.TitleIDTextBox, 0, 1);
            this.InputTable.Controls.Add(this.TitleNameTextBox, 0, 2);
            this.InputTable.Controls.Add(this.RegionCheckedList, 1, 1);
            this.InputTable.Controls.Add(this.CategoryCheckedList, 2, 1);
            this.InputTable.Controls.Add(this.GenerateCetkButton, 0, 3);
            this.InputTable.Controls.Add(this.WarningLabel, 0, 4);
            this.InputTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputTable.Location = new System.Drawing.Point(1, 1);
            this.InputTable.Name = "InputTable";
            this.InputTable.RowCount = 5;
            this.InputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputTable.Size = new System.Drawing.Size(702, 217);
            this.InputTable.SizeOriginal = new System.Drawing.Size(702, 217);
            this.InputTable.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.InputTable.SetColumnSpan(this.TitleLabel, 3);
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.TitleLabel.ForeColorType = App.Core.Desktop.LabelType.primary;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(702, 34);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "WiiU cetk Generator";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleIDTextBox
            // 
            this.TitleIDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleIDTextBox.LabelText = "Title ID";
            this.TitleIDTextBox.Location = new System.Drawing.Point(0, 38);
            this.TitleIDTextBox.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.TitleIDTextBox.Mask = App.Core.Desktop.TextMask.None;
            this.TitleIDTextBox.MaxLength = 16;
            this.TitleIDTextBox.Name = "TitleIDTextBox";
            this.TitleIDTextBox.Size = new System.Drawing.Size(349, 34);
            this.TitleIDTextBox.TabIndex = 1;
            this.TitleIDTextBox.TextAlign = App.Core.Desktop.FlatMaskedTextBox.TextAlignTypes.Left;
            // 
            // TitleNameTextBox
            // 
            this.TitleNameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TitleNameTextBox.LabelText = "Title Name";
            this.TitleNameTextBox.Location = new System.Drawing.Point(0, 117);
            this.TitleNameTextBox.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.TitleNameTextBox.MaxLength = 0;
            this.TitleNameTextBox.Name = "TitleNameTextBox";
            this.TitleNameTextBox.PreviousText = "";
            this.TitleNameTextBox.Size = new System.Drawing.Size(349, 34);
            this.TitleNameTextBox.TabIndex = 2;
            // 
            // RegionCheckedList
            // 
            this.RegionCheckedList.DataSource = null;
            this.RegionCheckedList.DisplayMember = "";
            this.RegionCheckedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegionCheckedList.Location = new System.Drawing.Point(353, 38);
            this.RegionCheckedList.Name = "RegionCheckedList";
            this.InputTable.SetRowSpan(this.RegionCheckedList, 2);
            this.RegionCheckedList.Size = new System.Drawing.Size(171, 113);
            this.RegionCheckedList.TabIndex = 3;
            this.RegionCheckedList.TextLegend = "Region";
            this.RegionCheckedList.ValueMember = "";
            // 
            // CategoryCheckedList
            // 
            this.CategoryCheckedList.DataSource = null;
            this.CategoryCheckedList.DisplayMember = "";
            this.CategoryCheckedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryCheckedList.Location = new System.Drawing.Point(528, 38);
            this.CategoryCheckedList.Name = "CategoryCheckedList";
            this.InputTable.SetRowSpan(this.CategoryCheckedList, 2);
            this.CategoryCheckedList.Size = new System.Drawing.Size(172, 113);
            this.CategoryCheckedList.TabIndex = 4;
            this.CategoryCheckedList.TextLegend = "Category";
            this.CategoryCheckedList.ValueMember = "";
            // 
            // GenerateCetkButton
            // 
            this.GenerateCetkButton.BorderColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.InputTable.SetColumnSpan(this.GenerateCetkButton, 3);
            this.GenerateCetkButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerateCetkButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.GenerateCetkButton.FlatAppearance.BorderSize = 0;
            this.GenerateCetkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.GenerateCetkButton.Location = new System.Drawing.Point(0, 155);
            this.GenerateCetkButton.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.GenerateCetkButton.Name = "GenerateCetkButton";
            this.GenerateCetkButton.Size = new System.Drawing.Size(702, 34);
            this.GenerateCetkButton.TabIndex = 5;
            this.GenerateCetkButton.Text = "Generate cetk";
            // 
            // WarningLabel
            // 
            this.InputTable.SetColumnSpan(this.WarningLabel, 3);
            this.WarningLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.WarningLabel.ForeColorType = App.Core.Desktop.LabelType.primary;
            this.WarningLabel.Location = new System.Drawing.Point(0, 193);
            this.WarningLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(702, 24);
            this.WarningLabel.TabIndex = 6;
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResultTable
            // 
            this.ResultTable.ColumnCount = 1;
            this.ResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResultTable.Controls.Add(this.TitlesGrid, 0, 0);
            this.ResultTable.Controls.Add(this.TitlesStatusBar, 0, 1);
            this.ResultTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultTable.Location = new System.Drawing.Point(1, 218);
            this.ResultTable.Name = "ResultTable";
            this.ResultTable.RowCount = 2;
            this.ResultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResultTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ResultTable.Size = new System.Drawing.Size(702, 405);
            this.ResultTable.SizeOriginal = new System.Drawing.Size(702, 405);
            this.ResultTable.TabIndex = 1;
            // 
            // TitlesGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TitlesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TitlesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.TitlesGrid.ColorBackground = System.Drawing.Color.White;
            this.TitlesGrid.ColorColumnHeader = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.TitlesGrid.ColorColumnHeaderMouseHover = System.Drawing.Color.Empty;
            this.TitlesGrid.ColorColumnHeaderReorderDiv = System.Drawing.Color.Empty;
            this.TitlesGrid.ColorColumnHeaderReorderRec = System.Drawing.Color.Empty;
            this.TitlesGrid.ColorColumnSelection = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.TitlesGrid.ColorFontRow = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitlesGrid.ColorFontRowSelection = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitlesGrid.ColorGrid = System.Drawing.Color.Silver;
            this.TitlesGrid.ColorRow = System.Drawing.Color.White;
            this.TitlesGrid.ColorRowAlternate = System.Drawing.Color.White;
            this.TitlesGrid.ColorRowMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.TitlesGrid.ColorRowSelection = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TitlesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TitlesGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.TitlesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitlesGrid.Location = new System.Drawing.Point(0, 2);
            this.TitlesGrid.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.TitlesGrid.Name = "TitlesGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TitlesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TitlesGrid.RowTemplate.Height = 30;
            this.TitlesGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TitlesGrid.Size = new System.Drawing.Size(702, 374);
            this.TitlesGrid.StandardTab = true;
            this.TitlesGrid.TabIndex = 0;
            this.TitlesGrid.TabStop = true;
            // 
            // TitlesStatusBar
            // 
            this.TitlesStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.TitlesStatusBar.BackColorContent = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TitlesStatusBar.BorderEnable = true;
            this.TitlesStatusBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlesStatusBar.Location = new System.Drawing.Point(3, 379);
            this.TitlesStatusBar.Movimento = App.Core.Desktop.Movimento.Nenhum;
            this.TitlesStatusBar.Name = "TitlesStatusBar";
            this.TitlesStatusBar.Registros = null;
            this.TitlesStatusBar.Size = new System.Drawing.Size(696, 23);
            this.TitlesStatusBar.TabIndex = 1;
            // 
            // WiiUcetkForm
            // 
            this.ClientSize = new System.Drawing.Size(704, 624);
            this.Controls.Add(this.MainContentTable);
            this.Name = "WiiUcetkForm";
            this.SizeOriginal = new System.Drawing.Size(430, 262);
            this.Text = "WiiUcetkForm";
            this.MainContentTable.ResumeLayout(false);
            this.MainContentTable.PerformLayout();
            this.InputTable.ResumeLayout(false);
            this.ResultTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitlesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatLabelA TitleLabel;
        internal FlatMaskedTextBoxA TitleIDTextBox;
        private FlatTableA MainContentTable;
        internal FlatButtonA GenerateCetkButton;
        internal FlatLabelA WarningLabel;
        private FlatTableA ResultTable;
        internal FlatTextBoxA TitleNameTextBox;
        internal FlatDataGridA TitlesGrid;
        internal FlatCheckedListA RegionCheckedList;
        internal FlatCheckedListA CategoryCheckedList;
        internal FlatStatusBarA TitlesStatusBar;
        private FlatTableA InputTable;
    }
}