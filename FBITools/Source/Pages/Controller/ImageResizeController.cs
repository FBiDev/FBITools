using System;
using System.Drawing;
using System.Windows.Forms;
using App.Core.Desktop;

namespace FBITools
{
    public partial class ImageResizeController
    {
        private readonly ImageResizeService service;

        public ImageResizeController(ImageResizeForm page)
        {
            service = new ImageResizeService();

            Page = page;
            Page.Shown += OnFormShown;
        }

        private void OnFormShown(object sender, EventArgs ev)
        {
            WarningLabel.TextChanged += ClearLabelText;

            service.EncoderChanged += UpdateOut;
            service.StatusChanged += Service_StatusChanged;
            service.Resized += Service_Resized;
            service.ResizeModeCrop += Service_ResizeModeCrop;

            OriginButton.Click += OriginButton_Click;
            DestinationButton.Click += DestinationButton_Click;
            ResizeButton.Click += ResizeButton_Click;

            service.LoadComboBoxData(
                EncoderComboBox,
                ResizeModeComboBox,
                SizesComboBox,
                AnchorComboBox,
                InterpolationComboBox,
                MatteColorComboBox,
                ColorProfileComboBox,
                SharpenComboBox,
                BlendingModeComboBox,
                HybridModeComboBox,
                JpgQualityComboBox,
                JpgChromaSubsampleComboBox,
                PngFilterComboBox,
                PngInterlaceComboBox);
        }

        private async void ClearLabelText(object sender, EventArgs e)
        {
            var label = (FlatLabel)sender;
            await label.ClearTextAfterDelay(4);
        }

        private void OriginButton_Click(object sender, EventArgs e)
        {
            if (service.PickImg())
            {
                UpdatePictureBoxImage(DropPictureBox, service.GetImgBitmap());
                UpdateImg();
                UpdateOut();
            }
        }

        private void DestinationButton_Click(object sender, EventArgs e)
        {
            if (service.PickOut())
            {
                UpdateOut();
            }
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            service.Resize();
        }

        private void UpdateImg()
        {
            OriginTextBox.Text = service.ImgPath;
        }

        private void UpdateOut()
        {
            DestinationTextBox.Text = service.OutPath;
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
            WarningLabel.ForeColorType = type;
            WarningLabel.Text = message;
        }

        private void Service_Resized()
        {
            UpdatePictureBoxImage(ResizedPictureBox, service.GetOutBitmap());
        }

        private void Service_ResizeModeCrop(bool isCrop)
        {
            AnchorComboBox.Enabled = isCrop;
        }
    }
}