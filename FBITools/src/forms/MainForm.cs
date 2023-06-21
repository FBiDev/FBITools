using GNX;
using System.Drawing;
using System.Windows.Forms;

namespace FBITools
{
    public partial class MainForm : FormBase
    {
        public CopyStateForm tabCopyState;
        public Size tabCopyStateSize;

        public MainForm()
        {
            InitializeComponent();
            MainCommon.Main_Init(this);

            tabCopyState = new CopyStateForm();
            tabCopyStateSize = tabCopyState.Size;
        }

        private void splitContainer1_Panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void flatButtonA1_Click(object sender, System.EventArgs e)
        {
            Height = tabCopyStateSize.Height + 84;
            Width = tabCopyStateSize.Width + 163;
            tabCopyState.Show();

            pnlContentL.Controls.Clear();
            pnlContentL.Controls.Add(tabCopyState);
            tabCopyState.Dock = DockStyle.Fill;
        }
    }
}