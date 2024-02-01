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
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Size = new System.Drawing.Size(405, 258);
            // 
            // staStatus
            // 
            this.staStatus.Size = new System.Drawing.Size(431, 24);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(431, 308);
            this.MinimumSize = new System.Drawing.Size(420, 290);
            this.Name = "MainForm";
            this.Text = "FBI Tools";
            this.ResumeLayout(false);

        }

        #endregion



    }
}

