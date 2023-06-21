namespace FBITools
{
    partial class CopyStateForm
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
            this.openFileSaveState = new System.Windows.Forms.OpenFileDialog();
            this.saveFileSaveState = new System.Windows.Forms.SaveFileDialog();
            this.lblCopySaveState = new FBITools.src.custom_controls.FlatLabelA();
            this.btnCopySaveState = new FBITools.FlatButtonA();
            this.txtSaveStateDestination = new FBITools.FlatTextBoxA();
            this.btnSaveSaveDestination = new FBITools.FlatButtonA();
            this.txtGetSaveState = new FBITools.FlatTextBoxA();
            this.btnGetSaveState = new FBITools.FlatButtonA();
            this.SuspendLayout();
            // 
            // openFileSaveState
            // 
            this.openFileSaveState.FileName = "StateOrigin";
            // 
            // lblCopySaveState
            // 
            this.lblCopySaveState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopySaveState.Location = new System.Drawing.Point(0, 164);
            this.lblCopySaveState.Name = "lblCopySaveState";
            this.lblCopySaveState.Padding = new System.Windows.Forms.Padding(4);
            this.lblCopySaveState.Size = new System.Drawing.Size(284, 98);
            this.lblCopySaveState.TabIndex = 5;
            this.lblCopySaveState.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCopySaveState
            // 
            this.btnCopySaveState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopySaveState.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCopySaveState.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnCopySaveState.FlatAppearance.BorderSize = 0;
            this.btnCopySaveState.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnCopySaveState.Location = new System.Drawing.Point(0, 130);
            this.btnCopySaveState.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnCopySaveState.Name = "btnCopySaveState";
            this.btnCopySaveState.Size = new System.Drawing.Size(284, 34);
            this.btnCopySaveState.TabIndex = 4;
            this.btnCopySaveState.Text = "Copy SaveState";
            this.btnCopySaveState.Click += new System.EventHandler(this.btnCopySaveState_Click);
            // 
            // txtSaveStateDestination
            // 
            this.txtSaveStateDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSaveStateDestination.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSaveStateDestination.LabelText = "Destination";
            this.txtSaveStateDestination.Location = new System.Drawing.Point(0, 96);
            this.txtSaveStateDestination.MaximumSize = new System.Drawing.Size(0, 34);
            this.txtSaveStateDestination.Name = "txtSaveStateDestination";
            this.txtSaveStateDestination.previousText = "";
            this.txtSaveStateDestination.SelectionLength = 0;
            this.txtSaveStateDestination.SelectionStart = 0;
            this.txtSaveStateDestination.Size = new System.Drawing.Size(284, 34);
            this.txtSaveStateDestination.TabIndex = 3;
            // 
            // btnSaveSaveDestination
            // 
            this.btnSaveSaveDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveSaveDestination.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveSaveDestination.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnSaveSaveDestination.FlatAppearance.BorderSize = 0;
            this.btnSaveSaveDestination.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnSaveSaveDestination.Location = new System.Drawing.Point(0, 68);
            this.btnSaveSaveDestination.Margin = new System.Windows.Forms.Padding(1);
            this.btnSaveSaveDestination.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnSaveSaveDestination.Name = "btnSaveSaveDestination";
            this.btnSaveSaveDestination.Size = new System.Drawing.Size(284, 28);
            this.btnSaveSaveDestination.TabIndex = 0;
            this.btnSaveSaveDestination.Text = "SaveState Destination";
            this.btnSaveSaveDestination.Click += new System.EventHandler(this.btnSaveSaveState_Click);
            // 
            // txtGetSaveState
            // 
            this.txtGetSaveState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGetSaveState.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGetSaveState.LabelText = "Origin";
            this.txtGetSaveState.Location = new System.Drawing.Point(0, 34);
            this.txtGetSaveState.MaximumSize = new System.Drawing.Size(0, 34);
            this.txtGetSaveState.Name = "txtGetSaveState";
            this.txtGetSaveState.previousText = "";
            this.txtGetSaveState.SelectionLength = 0;
            this.txtGetSaveState.SelectionStart = 0;
            this.txtGetSaveState.Size = new System.Drawing.Size(284, 34);
            this.txtGetSaveState.TabIndex = 2;
            // 
            // btnGetSaveState
            // 
            this.btnGetSaveState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetSaveState.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGetSaveState.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnGetSaveState.FlatAppearance.BorderSize = 0;
            this.btnGetSaveState.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnGetSaveState.Location = new System.Drawing.Point(0, 0);
            this.btnGetSaveState.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnGetSaveState.Name = "btnGetSaveState";
            this.btnGetSaveState.Size = new System.Drawing.Size(284, 34);
            this.btnGetSaveState.TabIndex = 1;
            this.btnGetSaveState.Text = "Get SaveState";
            this.btnGetSaveState.Click += new System.EventHandler(this.btnCopyStateFile_Click);
            // 
            // CopyStateForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.lblCopySaveState);
            this.Controls.Add(this.btnCopySaveState);
            this.Controls.Add(this.txtSaveStateDestination);
            this.Controls.Add(this.btnSaveSaveDestination);
            this.Controls.Add(this.txtGetSaveState);
            this.Controls.Add(this.btnGetSaveState);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CopyStateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CopyStateForm";
            this.ResumeLayout(false);

        }

        #endregion

        private FlatButtonA btnSaveSaveDestination;
        private System.Windows.Forms.OpenFileDialog openFileSaveState;
        private FlatButtonA btnGetSaveState;
        private FlatTextBoxA txtGetSaveState;
        private System.Windows.Forms.SaveFileDialog saveFileSaveState;
        private FlatTextBoxA txtSaveStateDestination;
        private FlatButtonA btnCopySaveState;
        private src.custom_controls.FlatLabelA lblCopySaveState;
    }
}