﻿namespace FBITools
{
    public partial class SaveStateForm : GNX.ContentBaseForm
    {
        public SaveStateForm()
        {
            InitializeComponent();
            SaveStateController.Init(this);
        }
    }
}