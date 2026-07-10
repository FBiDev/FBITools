using System;
using System.ComponentModel;

namespace FBITools
{
    public class Rom
    {
        public Rom()
        {
        }

        [Display(IsBool = IsBool.Yes, AutoGenerateField = true)]
        public bool Found { get; set; }

        [Style(AutoSizeMode = ColumnAutoSizeMode.Fill)]
        public string FileName { get; set; }

        [Style(Align = ColumnAlign.Right, AutoSizeMode = ColumnAutoSizeMode.AllCells)]
        public long FileSize { get; set; }

        [Style(AutoSizeMode = ColumnAutoSizeMode.AllCells)]
        public DateTime Date { get; set; }
    }
}