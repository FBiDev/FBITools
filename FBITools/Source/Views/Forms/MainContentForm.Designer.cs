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
            this.pnlContentL = new FBITools.FlatPanelA();
            this.btnSaveStateTab = new FBITools.FlatButtonA();
            this.btnMemoryCardTab = new FBITools.FlatButtonA();
            this.pnlContentL.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContentR
            // 
            this.pnlContentR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlContentR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentR.Location = new System.Drawing.Point(124, 0);
            this.pnlContentR.Name = "pnlContentR";
            this.pnlContentR.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.pnlContentR.Size = new System.Drawing.Size(306, 262);
            this.pnlContentR.TabIndex = 3;
            // 
            // pnlContentL
            // 
            this.pnlContentL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.pnlContentL.Controls.Add(this.btnMemoryCardTab);
            this.pnlContentL.Controls.Add(this.btnSaveStateTab);
            this.pnlContentL.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContentL.Location = new System.Drawing.Point(0, 0);
            this.pnlContentL.Name = "pnlContentL";
            this.pnlContentL.Size = new System.Drawing.Size(124, 262);
             this.pnlContentL.TabIndex = 2;
            // 
            // btnSaveStateTab
            // 
            this.btnSaveStateTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveStateTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnSaveStateTab.FlatAppearance.BorderSize = 0;
            this.btnSaveStateTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnSaveStateTab.Location = new System.Drawing.Point(0, 0);
            this.btnSaveStateTab.Name = "btnSaveStateTab";
            this.btnSaveStateTab.Size = new System.Drawing.Size(124, 34);
            this.btnSaveStateTab.TabIndex = 0;
            this.btnSaveStateTab.Text = "SaveState";
            // 
            // btnMemoryCardTab
            // 
            this.btnMemoryCardTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemoryCardTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnMemoryCardTab.FlatAppearance.BorderSize = 0;
            this.btnMemoryCardTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnMemoryCardTab.Location = new System.Drawing.Point(0, 34);
            this.btnMemoryCardTab.Name = "btnMemoryCardTab";
            this.btnMemoryCardTab.Size = new System.Drawing.Size(124, 34);
            this.btnMemoryCardTab.TabIndex = 1;
            this.btnMemoryCardTab.Text = "MemoryCard";
            // 
            // MainContentForm
            // 
            this.ClientSize = new System.Drawing.Size(430, 262);
            this.Controls.Add(this.pnlContentR);
            this.Controls.Add(this.pnlContentL);
            this.Name = "MainContentForm";
            this.Text = "MainContentForm";
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