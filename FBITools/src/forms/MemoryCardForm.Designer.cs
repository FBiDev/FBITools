namespace FBITools
{
    partial class MemoryCardForm
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
            this.dlgMcOrigin = new System.Windows.Forms.OpenFileDialog();
            this.dlgMcDestination = new System.Windows.Forms.SaveFileDialog();
            this.lblMcBackup = new FBITools.FlatLabelA();
            this.pnlMcBackup = new FBITools.FlatPanelA();
            this.btnMcBackup = new FBITools.FlatButtonA();
            this.pnlMcTimer = new FBITools.FlatPanelA();
            this.cboMcTimer = new FBITools.FlatComboBoxA();
            this.pnlMcDestination = new FBITools.FlatPanelA();
            this.btnMcDestination = new FBITools.FlatButtonA();
            this.txtMcDestination = new FBITools.FlatTextBoxA();
            this.pnlMcOrigin = new FBITools.FlatPanelA();
            this.btnMcOrigin = new FBITools.FlatButtonA();
            this.txtMcOrigin = new FBITools.FlatTextBoxA();
            this.pnlMcTitle = new FBITools.FlatPanelA();
            this.lblMcTitle = new FBITools.FlatLabelA();
            this.pnlMcBackup.SuspendLayout();
            this.pnlMcTimer.SuspendLayout();
            this.pnlMcDestination.SuspendLayout();
            this.pnlMcOrigin.SuspendLayout();
            this.pnlMcTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgMcOrigin
            // 
            this.dlgMcOrigin.FileName = "StateOrigin";
            // 
            // lblMcBackup
            // 
            this.lblMcBackup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMcBackup.Location = new System.Drawing.Point(2, 195);
            this.lblMcBackup.Name = "lblMcBackup";
            this.lblMcBackup.Padding = new System.Windows.Forms.Padding(4);
            this.lblMcBackup.Size = new System.Drawing.Size(426, 65);
            this.lblMcBackup.TabIndex = 5;
            this.lblMcBackup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlMcBackup
            // 
            this.pnlMcBackup.BorderRound = false;
            this.pnlMcBackup.BorderSize = 0;
            this.pnlMcBackup.Controls.Add(this.btnMcBackup);
            this.pnlMcBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMcBackup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMcBackup.Location = new System.Drawing.Point(2, 154);
            this.pnlMcBackup.Name = "pnlMcBackup";
            this.pnlMcBackup.Padding = new System.Windows.Forms.Padding(2);
            this.pnlMcBackup.Size = new System.Drawing.Size(426, 38);
            this.pnlMcBackup.TabIndex = 9;
            // 
            // btnMcBackup
            // 
            this.btnMcBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMcBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMcBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnMcBackup.FlatAppearance.BorderSize = 0;
            this.btnMcBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnMcBackup.Location = new System.Drawing.Point(2, 2);
            this.btnMcBackup.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnMcBackup.Name = "btnMcBackup";
            this.btnMcBackup.Size = new System.Drawing.Size(422, 34);
            this.btnMcBackup.TabIndex = 4;
            this.btnMcBackup.Text = "Backup Start";
            // 
            // pnlMcTimer
            // 
            this.pnlMcTimer.BorderRound = false;
            this.pnlMcTimer.BorderSize = 0;
            this.pnlMcTimer.Controls.Add(this.cboMcTimer);
            this.pnlMcTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMcTimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMcTimer.Location = new System.Drawing.Point(2, 116);
            this.pnlMcTimer.Name = "pnlMcTimer";
            this.pnlMcTimer.Padding = new System.Windows.Forms.Padding(2);
            this.pnlMcTimer.Size = new System.Drawing.Size(426, 38);
            this.pnlMcTimer.TabIndex = 12;
            // 
            // cboMcTimer
            // 
            this.cboMcTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cboMcTimer.Dock = System.Windows.Forms.DockStyle.Right;
            this.cboMcTimer.LabelText = "Timer (Minutes)";
            this.cboMcTimer.Location = new System.Drawing.Point(86, 2);
            this.cboMcTimer.Name = "cboMcTimer";
            this.cboMcTimer.Size = new System.Drawing.Size(338, 34);
            this.cboMcTimer.TabIndex = 11;
            // 
            // pnlMcDestination
            // 
            this.pnlMcDestination.BorderRound = false;
            this.pnlMcDestination.BorderSize = 0;
            this.pnlMcDestination.Controls.Add(this.btnMcDestination);
            this.pnlMcDestination.Controls.Add(this.txtMcDestination);
            this.pnlMcDestination.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMcDestination.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMcDestination.Location = new System.Drawing.Point(2, 78);
            this.pnlMcDestination.Name = "pnlMcDestination";
            this.pnlMcDestination.Padding = new System.Windows.Forms.Padding(2);
            this.pnlMcDestination.Size = new System.Drawing.Size(426, 38);
            this.pnlMcDestination.TabIndex = 8;
            // 
            // btnMcDestination
            // 
            this.btnMcDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMcDestination.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMcDestination.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnMcDestination.FlatAppearance.BorderSize = 0;
            this.btnMcDestination.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnMcDestination.Location = new System.Drawing.Point(2, 2);
            this.btnMcDestination.Margin = new System.Windows.Forms.Padding(1);
            this.btnMcDestination.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnMcDestination.Name = "btnMcDestination";
            this.btnMcDestination.Size = new System.Drawing.Size(80, 34);
            this.btnMcDestination.TabIndex = 0;
            this.btnMcDestination.Text = "Destination";
            // 
            // txtMcDestination
            // 
            this.txtMcDestination.LabelText = "File";
            this.txtMcDestination.Location = new System.Drawing.Point(86, 2);
            this.txtMcDestination.MaximumSize = new System.Drawing.Size(0, 34);
            this.txtMcDestination.Name = "txtMcDestination";
            this.txtMcDestination.previousText = "";
            this.txtMcDestination.ReadOnly = true;
            this.txtMcDestination.SelectionLength = 0;
            this.txtMcDestination.SelectionStart = 0;
            this.txtMcDestination.Size = new System.Drawing.Size(338, 34);
            this.txtMcDestination.TabIndex = 3;
            // 
            // pnlMcOrigin
            // 
            this.pnlMcOrigin.BorderRound = false;
            this.pnlMcOrigin.BorderSize = 0;
            this.pnlMcOrigin.Controls.Add(this.btnMcOrigin);
            this.pnlMcOrigin.Controls.Add(this.txtMcOrigin);
            this.pnlMcOrigin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMcOrigin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMcOrigin.Location = new System.Drawing.Point(2, 40);
            this.pnlMcOrigin.Name = "pnlMcOrigin";
            this.pnlMcOrigin.Padding = new System.Windows.Forms.Padding(2);
            this.pnlMcOrigin.Size = new System.Drawing.Size(426, 38);
            this.pnlMcOrigin.TabIndex = 7;
            // 
            // btnMcOrigin
            // 
            this.btnMcOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMcOrigin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMcOrigin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnMcOrigin.FlatAppearance.BorderSize = 0;
            this.btnMcOrigin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnMcOrigin.Location = new System.Drawing.Point(2, 2);
            this.btnMcOrigin.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnMcOrigin.Name = "btnMcOrigin";
            this.btnMcOrigin.Size = new System.Drawing.Size(80, 34);
            this.btnMcOrigin.TabIndex = 1;
            this.btnMcOrigin.Text = "Origin";
            // 
            // txtMcOrigin
            // 
            this.txtMcOrigin.LabelText = "File";
            this.txtMcOrigin.Location = new System.Drawing.Point(86, 2);
            this.txtMcOrigin.MaximumSize = new System.Drawing.Size(0, 34);
            this.txtMcOrigin.Name = "txtMcOrigin";
            this.txtMcOrigin.previousText = "";
            this.txtMcOrigin.ReadOnly = true;
            this.txtMcOrigin.SelectionLength = 0;
            this.txtMcOrigin.SelectionStart = 0;
            this.txtMcOrigin.Size = new System.Drawing.Size(338, 34);
            this.txtMcOrigin.TabIndex = 2;
            // 
            // pnlMcTitle
            // 
            this.pnlMcTitle.BorderRound = false;
            this.pnlMcTitle.BorderSize = 0;
            this.pnlMcTitle.Controls.Add(this.lblMcTitle);
            this.pnlMcTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMcTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMcTitle.Location = new System.Drawing.Point(2, 2);
            this.pnlMcTitle.Name = "pnlMcTitle";
            this.pnlMcTitle.Padding = new System.Windows.Forms.Padding(2);
            this.pnlMcTitle.Size = new System.Drawing.Size(426, 38);
            this.pnlMcTitle.TabIndex = 10;
            // 
            // lblMcTitle
            // 
            this.lblMcTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMcTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMcTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMcTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblMcTitle.Location = new System.Drawing.Point(2, 2);
            this.lblMcTitle.Name = "lblMcTitle";
            this.lblMcTitle.Size = new System.Drawing.Size(422, 34);
            this.lblMcTitle.TabIndex = 6;
            this.lblMcTitle.Text = "MemoryCard";
            this.lblMcTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemoryCardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(430, 262);
            this.ControlBox = false;
            this.Controls.Add(this.lblMcBackup);
            this.Controls.Add(this.pnlMcBackup);
            this.Controls.Add(this.pnlMcTimer);
            this.Controls.Add(this.pnlMcDestination);
            this.Controls.Add(this.pnlMcOrigin);
            this.Controls.Add(this.pnlMcTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemoryCardForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CopyStateForm";
            this.pnlMcBackup.ResumeLayout(false);
            this.pnlMcTimer.ResumeLayout(false);
            this.pnlMcDestination.ResumeLayout(false);
            this.pnlMcOrigin.ResumeLayout(false);
            this.pnlMcTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatLabelA lblMcTitle;
        private FlatPanelA pnlMcBackup;
        private FlatPanelA pnlMcTitle;
        internal FlatButtonA btnMcDestination;
        internal FlatButtonA btnMcOrigin;
        internal FlatTextBoxA txtMcOrigin;
        internal FlatTextBoxA txtMcDestination;
        internal FlatButtonA btnMcBackup;
        internal FlatLabelA lblMcBackup;
        internal System.Windows.Forms.OpenFileDialog dlgMcOrigin;
        internal System.Windows.Forms.SaveFileDialog dlgMcDestination;
        internal FlatComboBoxA cboMcTimer;
        internal FlatPanelA pnlMcOrigin;
        internal FlatPanelA pnlMcDestination;
        internal FlatPanelA pnlMcTimer;
    }
}