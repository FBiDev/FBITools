using System;

namespace FBITools
{
    public partial class MainCommon
    {
        #region MAIN
        public static void Main_Init(MainForm formDesign)
        {
            BIND.form = formDesign;
            form.Init(form);

            //form.StatusBar = false;
        }

        static void Main_Load(object sender, EventArgs e) { }

        //static async void Main_Shown(object sender, EventArgs e) { }
        #endregion

        #region Common
        #endregion
    }
}