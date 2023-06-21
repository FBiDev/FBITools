﻿using System.Drawing;

namespace FBITools
{
    public class FlatButtonA : GNX.FlatButton
    {
        public FlatButtonA()
        {
            ForeColor = ForeColor;
            //this.BackgroundColor = Color.FromArgb(0, 132, 255);
            //this.BackgroundColorFocus = this.BackgroundColor;
            //TextColor = Color.White;
        }

        public void DarkMode()
        {
            BackgroundColor = ColorTranslator.FromHtml("#505050");
            BackgroundColorFocus = BackgroundColor;
            TextColor = ColorTranslator.FromHtml("#D2D2D2");
            BorderColor = ColorTranslator.FromHtml("#262626");
        }
    }
}