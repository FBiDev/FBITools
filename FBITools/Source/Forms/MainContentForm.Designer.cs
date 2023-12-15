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
            this.btnTabSaveState = new FBITools.FlatButtonA();
            this.btnTabMemoryCard = new FBITools.FlatButtonA();
            this.btnTabConfig = new FBITools.FlatButtonA();
            this.pnlContentR.SuspendLayout();
            this.pnlContentL.SuspendLayout();
            this.tblMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContentR
            // 
            this.pnlContentR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlContentR.BackColorType = GNX.Desktop.PanelType.white;
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
            this.tblMenu.Controls.Add(this.btnTabSaveState, 0, 0);
            this.tblMenu.Controls.Add(this.btnTabMemoryCard, 0, 1);
            this.tblMenu.Controls.Add(this.btnTabConfig, 0, 2);
            this.tblMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMenu.Location = new System.Drawing.Point(0, 0);
            this.tblMenu.Name = "tblMenu";
            this.tblMenu.Padding = new System.Windows.Forms.Padding(1);
            this.tblMenu.RowCount = 3;
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMenu.Size = new System.Drawing.Size(124, 262);
            this.tblMenu.SizeOriginal = new System.Drawing.Size(124, 262);
            this.tblMenu.TabIndex = 5;
            // 
            // btnTabSaveState
            // 
            this.btnTabSaveState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTabSaveState.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnTabSaveState.FlatAppearance.BorderSize = 0;
            this.btnTabSaveState.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnTabSaveState.Location = new System.Drawing.Point(1, 1);
            this.btnTabSaveState.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnTabSaveState.Name = "btnTabSaveState";
            this.btnTabSaveState.Size = new System.Drawing.Size(122, 34);
            this.btnTabSaveState.TabIndex = 0;
            this.btnTabSaveState.Text = "SaveState";
            // 
            // btnTabMemoryCard
            // 
            this.btnTabMemoryCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTabMemoryCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnTabMemoryCard.FlatAppearance.BorderSize = 0;
            this.btnTabMemoryCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnTabMemoryCard.Location = new System.Drawing.Point(1, 39);
            this.btnTabMemoryCard.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnTabMemoryCard.Name = "btnTabMemoryCard";
            this.btnTabMemoryCard.Size = new System.Drawing.Size(122, 34);
            this.btnTabMemoryCard.TabIndex = 1;
            this.btnTabMemoryCard.Text = "MemoryCard";
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
            this.btnTabConfig.TabIndex = 2;
            this.btnTabConfig.Text = "Configurações";
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
        internal FlatButtonA btnTabSaveState;
        internal FlatButtonA btnTabMemoryCard;
        internal FlatPanelA pnlContentR;
        internal FlatPanelA pnlContentRInside;
        private FlatTableLayoutPanelA tblMenu;
        internal FlatButtonA btnTabConfig;
    }
}