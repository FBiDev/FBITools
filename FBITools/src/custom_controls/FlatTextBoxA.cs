using System.Drawing;

namespace FBITools
{
    public class FlatTextBoxA : GNX.FlatTextBox
    {
        public void DarkMode()
        {
            BackgroundColor = ColorTranslator.FromHtml("#191919");
            BackgroundColorFocus = BackgroundColor;
            LabelTextColor = ColorTranslator.FromHtml("#A3B2DC");
            TextColor = ColorTranslator.FromHtml("#D2D2D2");
            TextColorFocus = TextColor;
            BorderColor = ColorTranslator.FromHtml("#424242");
            //BorderColor = BorderColorFocus;
        }
    }
}