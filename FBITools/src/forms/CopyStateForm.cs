using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FBITools
{
    public partial class CopyStateForm : Form
    {
        public string SaveStateOrigin { get; set; }
        public string SaveStateDestination { get; set; }

        public CopyStateForm()
        {
            InitializeComponent();
            TopLevel = false;

            openFileSaveState.ValidateNames = true;
            openFileSaveState.CheckFileExists = true;
            openFileSaveState.CheckPathExists = true;

            // Always default to Folder Selection.
            openFileSaveState.FileName = "";
            //openFileStateOrigin.FileName = "Folder Selection.";
            //string filePath = Path.GetDirectoryName(openFileStateOrigin.FileName);

            saveFileSaveState.Filter = "All Files (*.*)|*.*";
        }

        private void btnCopyStateFile_Click(object sender, EventArgs e)
        {
            if (openFileSaveState.ShowDialog() == DialogResult.OK)
            {
                SaveStateOrigin = openFileSaveState.FileName;
                txtGetSaveState.Text = SaveStateOrigin;
                saveFileSaveState.FileName = new FileInfo(SaveStateOrigin).Name;
            }
        }

        private void btnSaveSaveState_Click(object sender, EventArgs e)
        {
            if (saveFileSaveState.ShowDialog() == DialogResult.OK)
            {
                SaveStateDestination = saveFileSaveState.FileName;
                txtSaveStateDestination.Text = SaveStateDestination;
            }
        }

        private void btnCopySaveState_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SaveStateOrigin)
                || string.IsNullOrWhiteSpace(SaveStateDestination)
                || SaveStateOrigin == SaveStateDestination)
            {
                lblCopySaveState.Text = "Save State Failed!";
                return;
            }

            File.Copy(SaveStateOrigin, SaveStateDestination, true);
            lblCopySaveState.Text = "Save State Copied!";
        }
    }
}