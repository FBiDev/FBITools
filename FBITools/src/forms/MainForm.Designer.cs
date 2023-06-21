namespace FBITools
{
    partial class MainForm
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
            this.btnSaveMemoryCard = new FBITools.FlatButtonA();
            this.btnCopyState = new FBITools.FlatButtonA();
            this.pnlContentL = new FBITools.FlatPanelA();
            this.pnlContentInside.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlContentR.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContentInside
            // 
            this.pnlContentInside.Controls.Add(this.pnlContentR);
            this.pnlContentInside.Controls.Add(this.pnlContentL);
            this.pnlContentInside.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContentInside.Size = new System.Drawing.Size(415, 268);
            // 
            // pnlContent
            // 
            this.pnlContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContent.Size = new System.Drawing.Size(415, 268);
            // 
            // staStatus
            // 
            this.staStatus.Size = new System.Drawing.Size(431, 24);
            // 
            // pnlContentR
            // 
            this.pnlContentR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnlContentR.BorderRound = false;
            this.pnlContentR.BorderSize = 0;
            this.pnlContentR.Controls.Add(this.btnSaveMemoryCard);
            this.pnlContentR.Controls.Add(this.btnCopyState);
            this.pnlContentR.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContentR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlContentR.Location = new System.Drawing.Point(3, 3);
            this.pnlContentR.Name = "pnlContentR";
            this.pnlContentR.Size = new System.Drawing.Size(123, 262);
            this.pnlContentR.TabIndex = 1;
            // 
            // btnSaveMemoryCard
            // 
            this.btnSaveMemoryCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveMemoryCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnSaveMemoryCard.FlatAppearance.BorderSize = 0;
            this.btnSaveMemoryCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnSaveMemoryCard.Location = new System.Drawing.Point(1, 36);
            this.btnSaveMemoryCard.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnSaveMemoryCard.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnSaveMemoryCard.Name = "btnSaveMemoryCard";
            this.btnSaveMemoryCard.Size = new System.Drawing.Size(121, 34);
            this.btnSaveMemoryCard.TabIndex = 1;
            this.btnSaveMemoryCard.Text = "SaveMemoryCard";
            // 
            // btnCopyState
            // 
            this.btnCopyState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyState.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnCopyState.FlatAppearance.BorderSize = 0;
            this.btnCopyState.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnCopyState.Location = new System.Drawing.Point(1, 1);
            this.btnCopyState.Margin = new System.Windows.Forms.Padding(0);
            this.btnCopyState.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnCopyState.Name = "btnCopyState";
            this.btnCopyState.Size = new System.Drawing.Size(121, 34);
            this.btnCopyState.TabIndex = 0;
            this.btnCopyState.Text = "CopyState";
            this.btnCopyState.Click += new System.EventHandler(this.flatButtonA1_Click);
            // 
            // pnlContentL
            // 
            this.pnlContentL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContentL.BorderRound = false;
            this.pnlContentL.BorderSize = 0;
            this.pnlContentL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlContentL.Location = new System.Drawing.Point(128, 3);
            this.pnlContentL.Name = "pnlContentL";
            this.pnlContentL.Size = new System.Drawing.Size(284, 262);
            this.pnlContentL.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 308);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnlContentInside.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContentR.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatButtonA btnCopyState;
        private FlatButtonA btnSaveMemoryCard;
        private FlatPanelA pnlContentL;
        private FlatPanelA pnlContentR;


    }
}

