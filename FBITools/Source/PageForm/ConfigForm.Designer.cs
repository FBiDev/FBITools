﻿// <auto-generated/>
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
            this.MainContentTable = new FBITools.FlatTableA();
            this.InputTable = new FBITools.FlatTableA();
            this.TitleLabel = new FBITools.FlatLabelA();
            this.DarkModeCheckBox = new FBITools.FlatCheckBoxA();
            this.AutoCenterWindowCheckBox = new FBITools.FlatCheckBoxA();
            this.AutoResizeWindowCheckBox = new FBITools.FlatCheckBoxA();
            this.DebugModeCheckBox = new FBITools.FlatCheckBoxA();
            this.MainContentTable.SuspendLayout();
            this.InputTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContentTable
            // 
            this.MainContentTable.ColumnCount = 1;
            this.MainContentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainContentTable.Controls.Add(this.InputTable, 0, 0);
            this.MainContentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentTable.FillOnFormResize = true;
            this.MainContentTable.Location = new System.Drawing.Point(0, 0);
            this.MainContentTable.Name = "MainContentTable";
            this.MainContentTable.Padding = new System.Windows.Forms.Padding(1);
            this.MainContentTable.RowCount = 2;
            this.MainContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainContentTable.Size = new System.Drawing.Size(300, 262);
            this.MainContentTable.SizeOriginal = new System.Drawing.Size(300, 262);
            this.MainContentTable.TabIndex = 10;
            // 
            // InputTable
            // 
            this.InputTable.ColumnCount = 2;
            this.InputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InputTable.Controls.Add(this.TitleLabel, 0, 0);
            this.InputTable.Controls.Add(this.DarkModeCheckBox, 0, 1);
            this.InputTable.Controls.Add(this.AutoCenterWindowCheckBox, 0, 2);
            this.InputTable.Controls.Add(this.AutoResizeWindowCheckBox, 0, 3);
            this.InputTable.Controls.Add(this.DebugModeCheckBox, 0, 4);
            this.InputTable.Location = new System.Drawing.Point(1, 1);
            this.InputTable.Name = "InputTable";
            this.InputTable.RowCount = 5;
            this.InputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputTable.Size = new System.Drawing.Size(298, 186);
            this.InputTable.SizeOriginal = new System.Drawing.Size(298, 186);
            this.InputTable.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.InputTable.SetColumnSpan(this.TitleLabel, 2);
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.TitleLabel.ForeColorType = App.Core.Desktop.LabelType.primary;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(298, 34);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Config";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DarkModeCheckBox
            // 
            this.InputTable.SetColumnSpan(this.DarkModeCheckBox, 2);
            this.DarkModeCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DarkModeCheckBox.Location = new System.Drawing.Point(0, 38);
            this.DarkModeCheckBox.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.DarkModeCheckBox.Name = "DarkModeCheckBox";
            this.DarkModeCheckBox.Size = new System.Drawing.Size(298, 34);
            this.DarkModeCheckBox.TabIndex = 1;
            this.DarkModeCheckBox.TextLegend = "Dark Mode";
            // 
            // AutoCenterWindowCheckBox
            // 
            this.InputTable.SetColumnSpan(this.AutoCenterWindowCheckBox, 2);
            this.AutoCenterWindowCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoCenterWindowCheckBox.Location = new System.Drawing.Point(0, 76);
            this.AutoCenterWindowCheckBox.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.AutoCenterWindowCheckBox.Name = "AutoCenterWindowCheckBox";
            this.AutoCenterWindowCheckBox.Size = new System.Drawing.Size(298, 34);
            this.AutoCenterWindowCheckBox.TabIndex = 2;
            this.AutoCenterWindowCheckBox.TextLegend = "AutoCenter Window";
            // 
            // AutoResizeWindowCheckBox
            // 
            this.InputTable.SetColumnSpan(this.AutoResizeWindowCheckBox, 2);
            this.AutoResizeWindowCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoResizeWindowCheckBox.Location = new System.Drawing.Point(0, 114);
            this.AutoResizeWindowCheckBox.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.AutoResizeWindowCheckBox.Name = "AutoResizeWindowCheckBox";
            this.AutoResizeWindowCheckBox.Size = new System.Drawing.Size(298, 34);
            this.AutoResizeWindowCheckBox.TabIndex = 3;
            this.AutoResizeWindowCheckBox.TextLegend = "AutoResize Window";
            // 
            // DebugModeCheckBox
            // 
            this.InputTable.SetColumnSpan(this.DebugModeCheckBox, 2);
            this.DebugModeCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebugModeCheckBox.Location = new System.Drawing.Point(0, 152);
            this.DebugModeCheckBox.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.DebugModeCheckBox.Name = "DebugModeCheckBox";
            this.DebugModeCheckBox.Size = new System.Drawing.Size(298, 34);
            this.DebugModeCheckBox.TabIndex = 4;
            this.DebugModeCheckBox.TextLegend = "Debug Mode";
            // 
            // ConfigForm
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(300, 262);
            this.Controls.Add(this.MainContentTable);
            this.Name = "ConfigForm";
            this.SizeOriginal = new System.Drawing.Size(430, 262);
            this.Text = "ConfigForm";
            this.MainContentTable.ResumeLayout(false);
            this.MainContentTable.PerformLayout();
            this.InputTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatLabelA TitleLabel;
        private FlatTableA MainContentTable;
        internal FlatCheckBoxA DarkModeCheckBox;
        internal FlatCheckBoxA DebugModeCheckBox;
        internal FlatCheckBoxA AutoResizeWindowCheckBox;
        internal FlatCheckBoxA AutoCenterWindowCheckBox;
        private FlatTableA InputTable;

    }
}