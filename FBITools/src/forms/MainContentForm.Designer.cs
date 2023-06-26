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
            this.pnlContentL = new FBITools.FlatPanelA();
            this.btnSaveStateTab = new FBITools.FlatButtonA();
            this.btnMemoryCardTab = new FBITools.FlatButtonA();
            this.pnlContentR = new FBITools.FlatPanelA();
            this.pnlContent.SuspendLayout();
            this.pnlContentL.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlContent.Controls.Add(this.pnlContentL);
            this.pnlContent.Controls.Add(this.pnlContentR);
            this.pnlContent.Location = new System.Drawing.Point(2, 2);
            this.pnlContent.Size = new System.Drawing.Size(426, 258);
            // 
            // pnlContentL
            // 
            this.pnlContentL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnlContentL.BorderRound = false;
            this.pnlContentL.BorderSize = 0;
            this.pnlContentL.Controls.Add(this.btnSaveStateTab);
            this.pnlContentL.Controls.Add(this.btnMemoryCardTab);
            this.pnlContentL.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContentL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlContentL.Location = new System.Drawing.Point(0, 0);
            this.pnlContentL.Name = "pnlContentL";
            this.pnlContentL.Size = new System.Drawing.Size(123, 258);
            this.pnlContentL.TabIndex = 2;
            // 
            // btnSaveStateTab
            // 
            this.btnSaveStateTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveStateTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnSaveStateTab.FlatAppearance.BorderSize = 0;
            this.btnSaveStateTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnSaveStateTab.Location = new System.Drawing.Point(1, 1);
            this.btnSaveStateTab.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveStateTab.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnSaveStateTab.Name = "btnSaveStateTab";
            this.btnSaveStateTab.Size = new System.Drawing.Size(121, 34);
            this.btnSaveStateTab.TabIndex = 0;
            this.btnSaveStateTab.Text = "SaveState";
            // 
            // btnMemoryCardTab
            // 
            this.btnMemoryCardTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMemoryCardTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnMemoryCardTab.FlatAppearance.BorderSize = 0;
            this.btnMemoryCardTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnMemoryCardTab.Location = new System.Drawing.Point(1, 36);
            this.btnMemoryCardTab.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnMemoryCardTab.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnMemoryCardTab.Name = "btnMemoryCardTab";
            this.btnMemoryCardTab.Size = new System.Drawing.Size(121, 34);
            this.btnMemoryCardTab.TabIndex = 1;
            this.btnMemoryCardTab.Text = "MemoryCard";
            // 
            // pnlContentR
            // 
            this.pnlContentR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContentR.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContentR.BorderRound = false;
            this.pnlContentR.BorderSize = 0;
            this.pnlContentR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlContentR.Location = new System.Drawing.Point(127, 0);
            this.pnlContentR.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.pnlContentR.Name = "pnlContentR";
            this.pnlContentR.Size = new System.Drawing.Size(299, 258);
            this.pnlContentR.TabIndex = 3;
            // 
            // MainContentForm
            // 
            this.ClientSize = new System.Drawing.Size(430, 262);
            this.Name = "MainContentForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "MainContentForm";
            this.pnlContent.ResumeLayout(false);
            this.pnlContentL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal FlatPanelA pnlContentL;
        internal FlatButtonA btnSaveStateTab;
        internal FlatButtonA btnMemoryCardTab;
        internal FlatPanelA pnlContentR;
    }
}