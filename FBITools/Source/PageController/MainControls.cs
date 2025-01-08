﻿// <auto-generated/>
namespace FBITools
{
    public partial class MainContentController
    {
        private MainContentForm Page
        {
            get { return Session.MainContentPage; }
            set { Session.MainContentPage = value; }
        }

        private FlatPanelA ContentLPanel { get { return Page.ContentLPanel; } }

        private FlatPanelA ContentRPanel { get { return Page.ContentRPanel; } }

        private FlatPanelA ContentRInsidePanel { get { return Page.ContentRInsidePanel; } }

        private FlatButtonA FileCopyTabButton { get { return Page.FileCopyTabButton; } }

        private FlatButtonA ImageResizeTabButton { get { return Page.ImageResizeTabButton; } }

        private FlatButtonA VbCsharpTabButton { get { return Page.VbCsharpTabButton; } }

        private FlatButtonA WiiUcetkTabButton { get { return Page.WiiUcetkTabButton; } }

        private FlatButtonA ConfigTabButton { get { return Page.ConfigTabButton; } }
    }

    public partial class ConfigController
    {
        private ConfigForm Page
        {
            get { return Session.ConfigPage; }
            set { Session.ConfigPage = value; }
        }

        private FlatCheckBoxA DarkModeCheckBox { get { return Page.DarkModeCheckBox; } }

        private FlatCheckBoxA WindowAutoCenterCheckBox { get { return Page.AutoCenterWindowCheckBox; } }

        private FlatCheckBoxA WindowAutoResizeCheckBox { get { return Page.AutoResizeWindowCheckBox; } }

        private FlatCheckBoxA DebugModeCheckBox { get { return Page.DebugModeCheckBox; } }
    }

    public partial class FileCopyController
    {
        private FileCopyForm Page
        {
            get { return Session.FileCopyPage; }
            set { Session.FileCopyPage = value; }
        }

        private FlatTableLayoutPanelA InputTable { get { return Page.InputTable; } }

        private FlatLabelA WarningLabel { get { return Page.WarningLabel; } }

        private FlatButtonA OriginButton { get { return Page.OriginButton; } }

        private FlatTextBoxA OriginTextBox { get { return Page.OriginTextBox; } }

        private FlatButtonA DestinationButton { get { return Page.DestinationButton; } }

        private FlatTextBoxA DestinationTextBox { get { return Page.DestinationTextBox; } }

        private FlatCheckBoxA CustomDestinationCheckBox { get { return Page.CustomDestinationCheckBox; } }

        private FlatComboBoxA TypeComboBox { get { return Page.TypeComboBox; } }

        private FlatComboBoxA TimerComboBox { get { return Page.TimerComboBox; } }

        private FlatButtonA CopyButton { get { return Page.CopyButton; } }
    }

    public partial class ImageResizeController
    {
        private ImageResizeForm Page
        {
            get { return Session.ImageResizePage; }
            set { Session.ImageResizePage = value; }
        }

        private FlatLabelA WarningLabel { get { return Page.WarningLabel; } }

        private FlatButtonA OriginButton { get { return Page.OriginButton; } }

        private FlatTextBoxA OriginTextBox { get { return Page.OriginTextBox; } }

        private FlatButtonA DestinationButton { get { return Page.DestinationButton; } }

        private FlatTextBoxA DestinationTextBox { get { return Page.DestinationTextBox; } }

        private FlatComboBoxA EncoderComboBox { get { return Page.EncoderComboBox; } }

        private FlatComboBoxA ResizeModeComboBox { get { return Page.ResizeModeComboBox; } }

        private FlatComboBoxA SizesComboBox { get { return Page.SizesComboBox; } }

        private FlatComboBoxA AnchorComboBox { get { return Page.AnchorComboBox; } }

        private FlatComboBoxA InterpolationComboBox { get { return Page.InterpolationComboBox; } }

        private FlatComboBoxA MatteColorComboBox { get { return Page.MatteColorComboBox; } }

        private FlatComboBoxA ColorProfileComboBox { get { return Page.ColorProfileComboBox; } }

        private FlatComboBoxA SharpenComboBox { get { return Page.SharpenComboBox; } }

        private FlatComboBoxA BlendingModeComboBox { get { return Page.BlendingModeComboBox; } }

        private FlatComboBoxA HybridModeComboBox { get { return Page.HybridModeComboBox; } }

        private FlatComboBoxA PngFilterComboBox { get { return Page.PngFilterComboBox; } }

        private FlatComboBoxA PngInterlaceComboBox { get { return Page.PngInterlaceComboBox; } }

        private FlatComboBoxA JpgQualityComboBox { get { return Page.JpgQualityComboBox; } }

        private FlatComboBoxA JpgChromaSubsampleComboBox { get { return Page.JpgChromaSubsampleComboBox; } }

        private FlatButtonA ResizeButton { get { return Page.ResizeButton; } }

        private FlatPictureBoxA DropPictureBox { get { return Page.DropPictureBox; } }

        private FlatPictureBoxA ResizedPictureBox { get { return Page.ResizedPictureBox; } }
    }

    public partial class VbToCsharpController
    {
        private VbToCsharpForm Page
        {
            get { return Session.VbToCsharpPage; }
            set { Session.VbToCsharpPage = value; }
        }

        private FlatLabelA WarningLabel { get { return Page.WarningLabel; } }

        private FlatTextBoxA InputTextBox { get { return Page.InputTextBox; } }

        private FlatButtonA ConvertButton { get { return Page.ConvertButton; } }

        private FlatButtonA CopyResultButton { get { return Page.CopyResultButton; } }

        private FlatButtonA ClearButton { get { return Page.ClearButton; } }

        private FlatTextBoxA OutputTextBox { get { return Page.OutputTextBox; } }
    }
}

namespace FBITools.WiiU
{
    public partial class WiiUcetkController
    {
        private WiiUcetkForm Page
        {
            get { return Session.WiiUCetkPage; }
            set { Session.WiiUCetkPage = value; }
        }

        private FlatLabelA WarningLabel { get { return Page.WarningLabel; } }

        private FlatMaskedTextBoxA TitleIDTextBox { get { return Page.TitleIDTextBox; } }

        private FlatTextBoxA TitleNameTextBox { get { return Page.TitleNameTextBox; } }

        private FlatCheckedListA RegionCheckedList { get { return Page.RegionCheckedList; } }

        private FlatCheckedListA CategoryCheckedList { get { return Page.CategoryCheckedList; } }

        private FlatButtonA GenerateCetkButton { get { return Page.GenerateCetkButton; } }

        private FlatDataGridA TitlesGrid { get { return Page.TitlesGrid; } }

        private FlatStatusBarA TitlesStatusBar { get { return Page.TitlesStatusBar; } }
    }
}