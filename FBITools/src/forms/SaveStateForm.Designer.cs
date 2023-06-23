namespace FBITools
{
    partial class SaveStateForm
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
            this.dlgSaveStateGet = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveStateSave = new System.Windows.Forms.SaveFileDialog();
            this.pnlSaveStateOrigin = new FBITools.FlatPanelA();
            this.btnSaveStateOrigin = new FBITools.FlatButtonA();
            this.txtSaveStateOrigin = new FBITools.FlatTextBoxA();
            this.lblSaveStateCopy = new FBITools.FlatLabelA();
            this.btnSaveStateCopy = new FBITools.FlatButtonA();
            this.txtSaveStateDestination = new FBITools.FlatTextBoxA();
            this.btnSaveSaveDestination = new FBITools.FlatButtonA();
            this.lblSaveStateTitle = new FBITools.FlatLabelA();
            this.pnlSaveStateDestination = new FBITools.FlatPanelA();
            this.pnlSaveStateCopy = new FBITools.FlatPanelA();
            this.pnlSaveStateTitle = new FBITools.FlatPanelA();
            this.pnlSaveStateOrigin.SuspendLayout();
            this.pnlSaveStateDestination.SuspendLayout();
            this.pnlSaveStateCopy.SuspendLayout();
            this.pnlSaveStateTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgSaveStateGet
            // 
            this.dlgSaveStateGet.FileName = "StateOrigin";
            // 
            // pnlSaveStateOrigin
            // 
            this.pnlSaveStateOrigin.BorderRound = false;
            this.pnlSaveStateOrigin.BorderSize = 0;
            this.pnlSaveStateOrigin.Controls.Add(this.btnSaveStateOrigin);
            this.pnlSaveStateOrigin.Controls.Add(this.txtSaveStateOrigin);
            this.pnlSaveStateOrigin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSaveStateOrigin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlSaveStateOrigin.Location = new System.Drawing.Point(2, 40);
            this.pnlSaveStateOrigin.Name = "pnlSaveStateOrigin";
            this.pnlSaveStateOrigin.Padding = new System.Windows.Forms.Padding(2);
            this.pnlSaveStateOrigin.Size = new System.Drawing.Size(426, 38);
            this.pnlSaveStateOrigin.TabIndex = 7;
            // 
            // btnSaveStateOrigin
            // 
            this.btnSaveStateOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveStateOrigin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSaveStateOrigin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnSaveStateOrigin.FlatAppearance.BorderSize = 0;
            this.btnSaveStateOrigin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnSaveStateOrigin.Location = new System.Drawing.Point(2, 2);
            this.btnSaveStateOrigin.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnSaveStateOrigin.Name = "btnSaveStateOrigin";
            this.btnSaveStateOrigin.Size = new System.Drawing.Size(80, 34);
            this.btnSaveStateOrigin.TabIndex = 1;
            this.btnSaveStateOrigin.Text = "Origin";
            // 
            // txtSaveStateOrigin
            // 
            this.txtSaveStateOrigin.LabelText = "File";
            this.txtSaveStateOrigin.Location = new System.Drawing.Point(86, 2);
            this.txtSaveStateOrigin.MaximumSize = new System.Drawing.Size(0, 34);
            this.txtSaveStateOrigin.Name = "txtSaveStateOrigin";
            this.txtSaveStateOrigin.previousText = "";
            this.txtSaveStateOrigin.ReadOnly = true;
            this.txtSaveStateOrigin.SelectionLength = 0;
            this.txtSaveStateOrigin.SelectionStart = 0;
            this.txtSaveStateOrigin.Size = new System.Drawing.Size(338, 34);
            this.txtSaveStateOrigin.TabIndex = 2;
            // 
            // lblSaveStateCopy
            // 
            this.lblSaveStateCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSaveStateCopy.Location = new System.Drawing.Point(2, 154);
            this.lblSaveStateCopy.Name = "lblSaveStateCopy";
            this.lblSaveStateCopy.Padding = new System.Windows.Forms.Padding(4);
            this.lblSaveStateCopy.Size = new System.Drawing.Size(426, 106);
            this.lblSaveStateCopy.TabIndex = 5;
            this.lblSaveStateCopy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSaveStateCopy
            // 
            this.btnSaveStateCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveStateCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveStateCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnSaveStateCopy.FlatAppearance.BorderSize = 0;
            this.btnSaveStateCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnSaveStateCopy.Location = new System.Drawing.Point(2, 2);
            this.btnSaveStateCopy.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnSaveStateCopy.Name = "btnSaveStateCopy";
            this.btnSaveStateCopy.Size = new System.Drawing.Size(422, 34);
            this.btnSaveStateCopy.TabIndex = 4;
            this.btnSaveStateCopy.Text = "Copy";
            // 
            // txtSaveStateDestination
            // 
            this.txtSaveStateDestination.LabelText = "File";
            this.txtSaveStateDestination.Location = new System.Drawing.Point(86, 2);
            this.txtSaveStateDestination.MaximumSize = new System.Drawing.Size(0, 34);
            this.txtSaveStateDestination.Name = "txtSaveStateDestination";
            this.txtSaveStateDestination.previousText = "";
            this.txtSaveStateDestination.ReadOnly = true;
            this.txtSaveStateDestination.SelectionLength = 0;
            this.txtSaveStateDestination.SelectionStart = 0;
            this.txtSaveStateDestination.Size = new System.Drawing.Size(338, 34);
            this.txtSaveStateDestination.TabIndex = 3;
            // 
            // btnSaveSaveDestination
            // 
            this.btnSaveSaveDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveSaveDestination.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSaveSaveDestination.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnSaveSaveDestination.FlatAppearance.BorderSize = 0;
            this.btnSaveSaveDestination.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnSaveSaveDestination.Location = new System.Drawing.Point(2, 2);
            this.btnSaveSaveDestination.Margin = new System.Windows.Forms.Padding(1);
            this.btnSaveSaveDestination.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnSaveSaveDestination.Name = "btnSaveSaveDestination";
            this.btnSaveSaveDestination.Size = new System.Drawing.Size(80, 34);
            this.btnSaveSaveDestination.TabIndex = 0;
            this.btnSaveSaveDestination.Text = "Destination";
            // 
            // lblSaveStateTitle
            // 
            this.lblSaveStateTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSaveStateTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSaveStateTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveStateTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSaveStateTitle.Location = new System.Drawing.Point(2, 2);
            this.lblSaveStateTitle.Name = "lblSaveStateTitle";
            this.lblSaveStateTitle.Size = new System.Drawing.Size(422, 34);
            this.lblSaveStateTitle.TabIndex = 6;
            this.lblSaveStateTitle.Text = "SaveState";
            this.lblSaveStateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSaveStateDestination
            // 
            this.pnlSaveStateDestination.BorderRound = false;
            this.pnlSaveStateDestination.BorderSize = 0;
            this.pnlSaveStateDestination.Controls.Add(this.btnSaveSaveDestination);
            this.pnlSaveStateDestination.Controls.Add(this.txtSaveStateDestination);
            this.pnlSaveStateDestination.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSaveStateDestination.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlSaveStateDestination.Location = new System.Drawing.Point(2, 78);
            this.pnlSaveStateDestination.Name = "pnlSaveStateDestination";
            this.pnlSaveStateDestination.Padding = new System.Windows.Forms.Padding(2);
            this.pnlSaveStateDestination.Size = new System.Drawing.Size(426, 38);
            this.pnlSaveStateDestination.TabIndex = 8;
            // 
            // pnlSaveStateCopy
            // 
            this.pnlSaveStateCopy.BorderRound = false;
            this.pnlSaveStateCopy.BorderSize = 0;
            this.pnlSaveStateCopy.Controls.Add(this.btnSaveStateCopy);
            this.pnlSaveStateCopy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSaveStateCopy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlSaveStateCopy.Location = new System.Drawing.Point(2, 116);
            this.pnlSaveStateCopy.Name = "pnlSaveStateCopy";
            this.pnlSaveStateCopy.Padding = new System.Windows.Forms.Padding(2);
            this.pnlSaveStateCopy.Size = new System.Drawing.Size(426, 38);
            this.pnlSaveStateCopy.TabIndex = 9;
            // 
            // pnlSaveStateTitle
            // 
            this.pnlSaveStateTitle.BorderRound = false;
            this.pnlSaveStateTitle.BorderSize = 0;
            this.pnlSaveStateTitle.Controls.Add(this.lblSaveStateTitle);
            this.pnlSaveStateTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSaveStateTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlSaveStateTitle.Location = new System.Drawing.Point(2, 2);
            this.pnlSaveStateTitle.Name = "pnlSaveStateTitle";
            this.pnlSaveStateTitle.Padding = new System.Windows.Forms.Padding(2);
            this.pnlSaveStateTitle.Size = new System.Drawing.Size(426, 38);
            this.pnlSaveStateTitle.TabIndex = 10;
            // 
            // SaveStateForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(430, 262);
            this.ControlBox = false;
            this.Controls.Add(this.lblSaveStateCopy);
            this.Controls.Add(this.pnlSaveStateCopy);
            this.Controls.Add(this.pnlSaveStateDestination);
            this.Controls.Add(this.pnlSaveStateOrigin);
            this.Controls.Add(this.pnlSaveStateTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveStateForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CopyStateForm";
            this.pnlSaveStateOrigin.ResumeLayout(false);
            this.pnlSaveStateDestination.ResumeLayout(false);
            this.pnlSaveStateCopy.ResumeLayout(false);
            this.pnlSaveStateTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatLabelA lblSaveStateTitle;
        private FlatPanelA pnlSaveStateOrigin;
        private FlatPanelA pnlSaveStateDestination;
        private FlatPanelA pnlSaveStateCopy;
        private FlatPanelA pnlSaveStateTitle;
        internal FlatButtonA btnSaveSaveDestination;
        internal FlatButtonA btnSaveStateOrigin;
        internal FlatTextBoxA txtSaveStateOrigin;
        internal FlatTextBoxA txtSaveStateDestination;
        internal FlatButtonA btnSaveStateCopy;
        internal FlatLabelA lblSaveStateCopy;
        internal System.Windows.Forms.OpenFileDialog dlgSaveStateGet;
        internal System.Windows.Forms.SaveFileDialog dlgSaveStateSave;
    }
}