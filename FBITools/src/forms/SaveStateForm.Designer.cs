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
            this.pnlResult = new FBITools.FlatPanelA();
            this.lblSaveStateCopy = new FBITools.FlatLabelA();
            this.pnlSaveStateCopy = new FBITools.FlatPanelA();
            this.btnSaveStateCopy = new FBITools.FlatButtonA();
            this.pnlSaveStateDestination = new FBITools.FlatPanelA();
            this.txtSaveStateDestination = new FBITools.FlatTextBoxA();
            this.btnSaveSaveDestination = new FBITools.FlatButtonA();
            this.pnlSaveStateOrigin = new FBITools.FlatPanelA();
            this.txtSaveStateOrigin = new FBITools.FlatTextBoxA();
            this.btnSaveStateOrigin = new FBITools.FlatButtonA();
            this.pnlSaveStateTitle = new FBITools.FlatPanelA();
            this.lblSaveStateTitle = new FBITools.FlatLabelA();
            this.pnlResult.SuspendLayout();
            this.pnlSaveStateCopy.SuspendLayout();
            this.pnlSaveStateDestination.SuspendLayout();
            this.pnlSaveStateOrigin.SuspendLayout();
            this.pnlSaveStateTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.lblSaveStateCopy);
            this.pnlResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResult.Location = new System.Drawing.Point(0, 152);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnlResult.Size = new System.Drawing.Size(430, 110);
            this.pnlResult.TabIndex = 1;
            // 
            // lblSaveStateCopy
            // 
            this.lblSaveStateCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSaveStateCopy.Location = new System.Drawing.Point(0, 2);
            this.lblSaveStateCopy.Name = "lblSaveStateCopy";
            this.lblSaveStateCopy.Size = new System.Drawing.Size(430, 108);
            this.lblSaveStateCopy.TabIndex = 5;
            this.lblSaveStateCopy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlSaveStateCopy
            // 
            this.pnlSaveStateCopy.Controls.Add(this.btnSaveStateCopy);
            this.pnlSaveStateCopy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSaveStateCopy.Location = new System.Drawing.Point(0, 114);
            this.pnlSaveStateCopy.Name = "pnlSaveStateCopy";
            this.pnlSaveStateCopy.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pnlSaveStateCopy.Size = new System.Drawing.Size(430, 38);
            this.pnlSaveStateCopy.TabIndex = 9;
            // 
            // btnSaveStateCopy
            // 
            this.btnSaveStateCopy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveStateCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnSaveStateCopy.FlatAppearance.BorderSize = 0;
            this.btnSaveStateCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnSaveStateCopy.Location = new System.Drawing.Point(0, 2);
            this.btnSaveStateCopy.Name = "btnSaveStateCopy";
            this.btnSaveStateCopy.Size = new System.Drawing.Size(430, 34);
            this.btnSaveStateCopy.TabIndex = 3;
            this.btnSaveStateCopy.Text = "Copy";
            // 
            // pnlSaveStateDestination
            // 
            this.pnlSaveStateDestination.Controls.Add(this.txtSaveStateDestination);
            this.pnlSaveStateDestination.Controls.Add(this.btnSaveSaveDestination);
            this.pnlSaveStateDestination.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSaveStateDestination.Location = new System.Drawing.Point(0, 76);
            this.pnlSaveStateDestination.Name = "pnlSaveStateDestination";
            this.pnlSaveStateDestination.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pnlSaveStateDestination.Size = new System.Drawing.Size(430, 38);
            this.pnlSaveStateDestination.TabIndex = 8;
            // 
            // txtSaveStateDestination
            // 
            this.txtSaveStateDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSaveStateDestination.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSaveStateDestination.BackgroundColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSaveStateDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSaveStateDestination.LabelText = "File";
            this.txtSaveStateDestination.Location = new System.Drawing.Point(80, 2);
            this.txtSaveStateDestination.MaximumSize = new System.Drawing.Size(0, 34);
            this.txtSaveStateDestination.Name = "txtSaveStateDestination";
            this.txtSaveStateDestination.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.txtSaveStateDestination.previousText = "";
            this.txtSaveStateDestination.ReadOnly = true;
            this.txtSaveStateDestination.Size = new System.Drawing.Size(350, 34);
            this.txtSaveStateDestination.TabIndex = 0;
            this.txtSaveStateDestination.TabStop = false;
            // 
            // btnSaveSaveDestination
            // 
            this.btnSaveSaveDestination.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSaveSaveDestination.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnSaveSaveDestination.FlatAppearance.BorderSize = 0;
            this.btnSaveSaveDestination.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnSaveSaveDestination.Location = new System.Drawing.Point(0, 2);
            this.btnSaveSaveDestination.Name = "btnSaveSaveDestination";
            this.btnSaveSaveDestination.Size = new System.Drawing.Size(80, 34);
            this.btnSaveSaveDestination.TabIndex = 2;
            this.btnSaveSaveDestination.Text = "Destination";
            // 
            // pnlSaveStateOrigin
            // 
            this.pnlSaveStateOrigin.Controls.Add(this.txtSaveStateOrigin);
            this.pnlSaveStateOrigin.Controls.Add(this.btnSaveStateOrigin);
            this.pnlSaveStateOrigin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSaveStateOrigin.Location = new System.Drawing.Point(0, 38);
            this.pnlSaveStateOrigin.Name = "pnlSaveStateOrigin";
            this.pnlSaveStateOrigin.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pnlSaveStateOrigin.Size = new System.Drawing.Size(430, 38);
            this.pnlSaveStateOrigin.TabIndex = 7;
            // 
            // txtSaveStateOrigin
            // 
            this.txtSaveStateOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSaveStateOrigin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSaveStateOrigin.BackgroundColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSaveStateOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSaveStateOrigin.LabelText = "File";
            this.txtSaveStateOrigin.Location = new System.Drawing.Point(80, 2);
            this.txtSaveStateOrigin.MaximumSize = new System.Drawing.Size(0, 34);
            this.txtSaveStateOrigin.Name = "txtSaveStateOrigin";
            this.txtSaveStateOrigin.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.txtSaveStateOrigin.previousText = "";
            this.txtSaveStateOrigin.ReadOnly = true;
            this.txtSaveStateOrigin.Size = new System.Drawing.Size(350, 34);
            this.txtSaveStateOrigin.TabIndex = 0;
            this.txtSaveStateOrigin.TabStop = false;
            // 
            // btnSaveStateOrigin
            // 
            this.btnSaveStateOrigin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSaveStateOrigin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnSaveStateOrigin.FlatAppearance.BorderSize = 0;
            this.btnSaveStateOrigin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnSaveStateOrigin.Location = new System.Drawing.Point(0, 2);
            this.btnSaveStateOrigin.Name = "btnSaveStateOrigin";
            this.btnSaveStateOrigin.Size = new System.Drawing.Size(80, 34);
            this.btnSaveStateOrigin.TabIndex = 1;
            this.btnSaveStateOrigin.Text = "Origin";
            // 
            // pnlSaveStateTitle
            // 
            this.pnlSaveStateTitle.Controls.Add(this.lblSaveStateTitle);
            this.pnlSaveStateTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSaveStateTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlSaveStateTitle.Name = "pnlSaveStateTitle";
            this.pnlSaveStateTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.pnlSaveStateTitle.Size = new System.Drawing.Size(430, 38);
            this.pnlSaveStateTitle.TabIndex = 10;
            // 
            // lblSaveStateTitle
            // 
            this.lblSaveStateTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSaveStateTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveStateTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSaveStateTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSaveStateTitle.Name = "lblSaveStateTitle";
            this.lblSaveStateTitle.Size = new System.Drawing.Size(430, 34);
            this.lblSaveStateTitle.TabIndex = 6;
            this.lblSaveStateTitle.Text = "SaveState";
            this.lblSaveStateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveStateForm
            // 
            this.ClientSize = new System.Drawing.Size(430, 262);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlSaveStateCopy);
            this.Controls.Add(this.pnlSaveStateDestination);
            this.Controls.Add(this.pnlSaveStateOrigin);
            this.Controls.Add(this.pnlSaveStateTitle);
            this.Name = "SaveStateForm";
            this.Text = "CopyStateForm";
            this.pnlResult.ResumeLayout(false);
            this.pnlSaveStateCopy.ResumeLayout(false);
            this.pnlSaveStateDestination.ResumeLayout(false);
            this.pnlSaveStateOrigin.ResumeLayout(false);
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
        private FlatPanelA pnlResult;
    }
}