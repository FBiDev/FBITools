using System;
using System.Drawing;
using System.Windows.Forms;
using App.Core.Desktop;

namespace FBITools
{
    public class ImageResizeCode : PageCode
    {
        private readonly ImageResizeController controller;

        public ImageResizeCode()
        {
            Session.ImageResizePage = this;

            base.UI = UI = new ImageResizeUI();
            UI.Shown += OnFormShown;

            controller = new ImageResizeController();
        }

        public new ImageResizeUI UI { get; set; }

        private void OnFormShown(object sender, EventArgs ev)
        {
            UI.WarningLabel.TextChanged += ClearLabelText;

            controller.EncoderChanged += UpdateOut;
            controller.StatusChanged += Service_StatusChanged;
            controller.Resized += Service_Resized;
            controller.ResizeModeCrop += Service_ResizeModeCrop;

            UI.OriginButton.Click += OriginButton_Click;
            UI.DestinationButton.Click += DestinationButton_Click;
            UI.ResizeButton.Click += ResizeButton_Click;

            controller.LoadComboBoxData(
                UI.EncoderComboBox,
                UI.ResizeModeComboBox,
                UI.SizesComboBox,
                UI.AnchorComboBox,
                UI.InterpolationComboBox,
                UI.MatteColorComboBox,
                UI.ColorProfileComboBox,
                UI.SharpenComboBox,
                UI.BlendingModeComboBox,
                UI.HybridModeComboBox,
                UI.JpgQualityComboBox,
                UI.JpgChromaSubsampleComboBox,
                UI.PngFilterComboBox,
                UI.PngInterlaceComboBox);
        }

        private async void ClearLabelText(object sender, EventArgs e)
        {
            var label = (FlatLabel)sender;
            await label.ClearTextAfterDelay(4);
        }

        private void OriginButton_Click(object sender, EventArgs e)
        {
            if (controller.PickImg())
            {
                UpdatePictureBoxImage(UI.DropPictureBox, controller.GetImgBitmap());
                UpdateImg();
                UpdateOut();
            }
        }

        private void DestinationButton_Click(object sender, EventArgs e)
        {
            if (controller.PickOut())
            {
                UpdateOut();
            }
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            controller.Resize();
        }

        private void UpdateImg()
        {
            UI.OriginTextBox.Text = controller.ImgPath;
        }

        private void UpdateOut()
        {
            UI.DestinationTextBox.Text = controller.OutPath;
        }

        private void UpdatePictureBoxImage(FlatPictureBox pictureBox, Bitmap image)
        {
            pictureBox.Image = image;

            if (image.Size.Width <= pictureBox.Width && image.Size.Height <= pictureBox.Height)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void Service_StatusChanged(string message, LabelType type)
        {
            UI.WarningLabel.ForeColorType = type;
            UI.WarningLabel.Text = message;
        }

        private void Service_Resized()
        {
            UpdatePictureBoxImage(UI.ResizedPictureBox, controller.GetOutBitmap());
        }

        private void Service_ResizeModeCrop(bool isCrop)
        {
            UI.AnchorComboBox.Enabled = isCrop;
        }
    }
}