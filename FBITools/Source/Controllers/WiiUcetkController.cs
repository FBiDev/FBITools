using System;
using System.Linq;
using System.Threading.Tasks;
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
            btnGenerateCetk.Click += btnGenerateCetk_Click;

            txtTitleID.TextChanged += (s, e) => SearchTitles().TryAwait();
            txtTitleName.TextChanged += (s, e) => SearchTitles().TryAwait();
            chkListRegion.ItemCheck += (s, e) => SearchTitles().TryAwait();
            chkListCategory.ItemCheck += (s, e) => SearchTitles().TryAwait();

            dgvTitles.Statusbar = staTitles;
        }

        async void lblWarning_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            lblWarning.Text = "";
        }

        async Task CarregarCamposAsync()
        {
            chkListRegion.Items.AddRange((await WiiU.Region.List()).Select(x => x.Name).ToArray());
            chkListRegion.SetItemsChecked(true);

            chkListCategory.Items.AddRange((await WiiU.Category.List()).Select(x => x.Name).ToArray());
            chkListCategory.SetItemsChecked(true);

            titles = new ListBind<WiiU.Title>(await WiiU.Title.Search(new WiiU.Title()));
            titlesFilter = titles;
            SetDataSource(titlesFilter);
        }

        Task SearchTitles()
        {
            string searchID = txtTitleID.Text;
            string searchName = txtTitleName.Text;

            //if (searchID.Length == 0 && searchName.Length == 0)
            //{
            //    SetDataSource(titles);
            //    return Task.CompletedTask;
            //}

            titlesFilter = new ListBind<WiiU.Title>();

            foreach (WiiU.Title obj in titles)
            {
                bool id = (obj.ID.HasValue() && obj.ID.Length >= searchID.Length && obj.ID.Substring(0, searchID.Length) == searchID.ToUpper());
                bool title = (obj.Name.ContainsExtend(searchName));
                bool region = chkListRegion.GetItemChecked(obj.Region);
                bool type = chkListCategory.GetItemChecked(obj.Category);

                if (id && title && region && type)
                {
                    titlesFilter.Add(obj);
                }
            }

            SetDataSource(titlesFilter);
            return Task.CompletedTask;
        }

        void SetDataSource(ListBind<WiiU.Title> list)
        {
            dgvTitles.DataSource = list;
            btnGenerateCetk.Enabled = list.Count > 0;
        }

        void btnGenerateCetk_Click(object sender, EventArgs e)
        {
            if (dgvTitles.SelectedRows.AnyRow() == false) return;

            var title = dgvTitles.GetCurrentRowObject<WiiU.Title>();
            var cetck = new HexFile(HexFile.WiiUcetk);
            cetck.ChangeValue(HexFile.WiiUcetkOldValue, title.Key);
            cetck.SaveWiiUcetk();

            lblWarning.Text = "cetk " + title + " Saved!";
        }
    }
}