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
            this.dlgOrigin = new System.Windows.Forms.OpenFileDialog();
            this.dlgDestination = new System.Windows.Forms.SaveFileDialog();
            this.pnlResult = new FBITools.FlatPanelA();
            this.lblResult = new FBITools.FlatLabelA();
            this.pnlCopy = new FBITools.FlatPanelA();
            this.btnCopy = new FBITools.FlatButtonA();
            this.pnlDestination = new FBITools.FlatPanelA();
            this.txtDestination = new FBITools.FlatTextBoxA();
            this.btnDestination = new FBITools.FlatButtonA();
            this.pnlOrigin = new FBITools.FlatPanelA();
            this.txtOrigin = new FBITools.FlatTextBoxA();
            this.btnOrigin = new FBITools.FlatButtonA();
            this.pnlTitle = new FBITools.FlatPanelA();
            this.lblTitle = new FBITools.FlatLabelA();
            this.pnlResult.SuspendLayout();
            this.pnlCopy.SuspendLayout();
            this.pnlDestination.SuspendLayout();
            this.pnlOrigin.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.lblResult);
            this.pnlResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResult.Location = new System.Drawing.Point(0, 152);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.OriginalBackColor = System.Drawing.Color.Empty;
            this.pnlResult.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pnlResult.Size = new System.Drawing.Size(430, 110);
            this.pnlResult.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.ForeColor = System.Drawing.Color.Firebrick;
            this.lblResult.Location = new System.Drawing.Point(0, 2);
            this.lblResult.Name = "lblResult";
            this.lblResult.OriginalForeColor = System.Drawing.Color.Empty;
            this.lblResult.Size = new System.Drawing.Size(430, 106);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlCopy
            // 
            this.pnlCopy.Controls.Add(this.btnCopy);
            this.pnlCopy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCopy.Location = new System.Drawing.Point(0, 114);
            this.pnlCopy.Name = "pnlCopy";
            this.pnlCopy.OriginalBackColor = System.Drawing.Color.Empty;
            this.pnlCopy.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pnlCopy.Size = new System.Drawing.Size(430, 38);
            this.pnlCopy.TabIndex = 9;
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnCopy.Location = new System.Drawing.Point(0, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(430, 34);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            // 
            // pnlDestination
            // 
            this.pnlDestination.Controls.Add(this.txtDestination);
            this.pnlDestination.Controls.Add(this.btnDestination);
            this.pnlDestination.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDestination.Location = new System.Drawing.Point(0, 76);
            this.pnlDestination.Name = "pnlDestination";
            this.pnlDestination.OriginalBackColor = System.Drawing.Color.Empty;
            this.pnlDestination.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pnlDestination.Size = new System.Drawing.Size(430, 38);
            this.pnlDestination.TabIndex = 8;
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDestination.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDestination.BackgroundColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDestination.LabelText = "File";
            this.txtDestination.Location = new System.Drawing.Point(80, 2);
            this.txtDestination.MaximumSize = new System.Drawing.Size(0, 34);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.txtDestination.previousText = "";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(350, 34);
            this.txtDestination.TabStop = false;
            // 
            // btnDestination
            // 
            this.btnDestination.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDestination.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnDestination.FlatAppearance.BorderSize = 0;
            this.btnDestination.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnDestination.Location = new System.Drawing.Point(0, 2);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(80, 34);
            this.btnDestination.TabIndex = 2;
            this.btnDestination.Text = "Destination";
            // 
            // pnlOrigin
            // 
            this.pnlOrigin.Controls.Add(this.txtOrigin);
            this.pnlOrigin.Controls.Add(this.btnOrigin);
            this.pnlOrigin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrigin.Location = new System.Drawing.Point(0, 38);
            this.pnlOrigin.Name = "pnlOrigin";
            this.pnlOrigin.OriginalBackColor = System.Drawing.Color.Empty;
            this.pnlOrigin.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pnlOrigin.Size = new System.Drawing.Size(430, 38);
            this.pnlOrigin.TabIndex = 7;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOrigin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtOrigin.BackgroundColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOrigin.LabelText = "File";
            this.txtOrigin.Location = new System.Drawing.Point(80, 2);
            this.txtOrigin.MaximumSize = new System.Drawing.Size(0, 34);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.txtOrigin.previousText = "";
            this.txtOrigin.ReadOnly = true;
            this.txtOrigin.Size = new System.Drawing.Size(350, 34);
            this.txtOrigin.TabStop = false;
            // 
            // btnOrigin
            // 
            this.btnOrigin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrigin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnOrigin.FlatAppearance.BorderSize = 0;
            this.btnOrigin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnOrigin.Location = new System.Drawing.Point(0, 2);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(80, 34);
            this.btnOrigin.TabIndex = 1;
            this.btnOrigin.Text = "Origin";
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.OriginalBackColor = System.Drawing.Color.Empty;
            this.pnlTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.pnlTitle.Size = new System.Drawing.Size(430, 38);
            this.pnlTitle.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.OriginalForeColor = System.Drawing.Color.Empty;
            this.lblTitle.Size = new System.Drawing.Size(430, 34);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "SaveState";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveStateForm
            // 
            this.ClientSize = new System.Drawing.Size(430, 262);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlCopy);
            this.Controls.Add(this.pnlDestination);
            this.Controls.Add(this.pnlOrigin);
            this.Controls.Add(this.pnlTitle);
            this.Name = "SaveStateForm";
            this.Text = "SaveStateForm";
            this.pnlResult.ResumeLayout(false);
            this.pnlCopy.ResumeLayout(false);
            this.pnlDestination.ResumeLayout(false);
            this.pnlOrigin.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatLabelA lblTitle;
        private FlatPanelA pnlOrigin;
        private FlatPanelA pnlDestination;
        private FlatPanelA pnlCopy;
        private FlatPanelA pnlTitle;
        internal FlatButtonA btnDestination;
        internal FlatButtonA btnOrigin;
        internal FlatTextBoxA txtOrigin;
        internal FlatTextBoxA txtDestination;
        internal FlatButtonA btnCopy;
        internal FlatLabelA lblResult;
        internal System.Windows.Forms.OpenFileDialog dlgOrigin;
        internal System.Windows.Forms.SaveFileDialog dlgDestination;
        private FlatPanelA pnlResult;
    }
}