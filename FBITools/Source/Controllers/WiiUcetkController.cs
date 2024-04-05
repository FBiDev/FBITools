using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public partial class WiiUcetkController
    {
        ListBind<WiiU.Title> titles = new ListBind<WiiU.Title>();
        ListBind<WiiU.Title> titlesFilter = new ListBind<WiiU.Title>();

        public WiiUcetkController(WiiUcetkForm formView)
        {
            form = formView;
            form.Shown += form_Shown;
            form.GotFocus += (s, e) => txtTitleID.Focus();
            form.FinalLoadOnceAsync += CarregarCamposAsync;
        }

        void form_Shown(object sender, EventArgs ev)
        {
            lblWarning.TextChanged += lblWarning_TextChanged;

            txtTitleID.TextChanged += (s, e) => SearchTitles().TryAwait();
            txtTitleName.TextChanged += (s, e) => SearchTitles().TryAwait();

            btnGenerateCetk.Click += btnGenerateCetk_Click;
            dgvTitles.DataSourceChanged += dgvTitles_DataSourceChanged;
        }

        async void lblWarning_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            lblWarning.Text = "";
        }

        async Task CarregarCamposAsync()
        {
            titles = new ListBind<WiiU.Title>(await WiiU.Title.Search(new WiiU.Title()));
            titlesFilter = titles;
            SetDataSource(titlesFilter);
        }

        Task SearchTitles()
        {
            string searchID = txtTitleID.Text;
            string searchName = txtTitleName.Text;

            if (searchID.Length == 0 && searchName.Length == 0)
            {
                SetDataSource(titles);
                return Task.CompletedTask;
            }

            titlesFilter = new ListBind<WiiU.Title>();

            foreach (WiiU.Title obj in titles)
            {
                bool id = (obj.ID.HasValue() && obj.ID.Length >= searchID.Length && obj.ID.Substring(0, searchID.Length) == searchID.ToUpper());
                bool title = (obj.Name.ContainsExtend(searchName));

                if (id && title)
                {
                    titlesFilter.Add(obj);
                }
            }

            SetDataSource(titlesFilter);
            return Task.CompletedTask;
        }

        void dgvTitles_DataSourceChanged(object sender, EventArgs e)
        {
            lblTitlesTotal.Text = "Titles Found: " + ((ListBind<WiiU.Title>)dgvTitles.DataSource).Count;
        }

        void SetDataSource(ListBind<WiiU.Title> list)
        {
            dgvTitles.DataSource = list;
        }

        void btnGenerateCetk_Click(object sender, EventArgs e)
        {
            if (dgvTitles.SelectedRows.AnyRow() == false) return;

            var title = dgvTitles.GetCurrentRowObject<WiiU.Title>();
            var cetck = new HexFile(HexFile.WiiUcetk);
            cetck.ChangeValue(HexFile.WiiUcetkOldValue, title.Key);
            cetck.SaveWiiUcetk();
        }
    }
}