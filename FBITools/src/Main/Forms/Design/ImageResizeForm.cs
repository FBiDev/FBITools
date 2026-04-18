using System;
using System.Drawing;
using System.Windows.Forms;
using App.Core.Desktop;

namespace FBITools
{
    public partial class ImageResizeForm : ContentBaseForm
    {
        private readonly ImageResizeController _controller;

        public ImageResizeForm()
        {
            InitializeComponent();

            Session.ImageResizePage = this;

            Shown += OnFormShown;

            _controller = new ImageResizeController();
        }

        private void OnFormShown(object sender, EventArgs ev)
        {
            WarningLabel.TextChanged += ClearLabelText;

            _controller.EncoderChanged += UpdateOut;
            _controller.StatusChanged += Service_StatusChanged;
            _controller.Resized += Service_Resized;
            _controller.ResizeModeCrop += Service_ResizeModeCrop;

            OriginButton.Click += OriginButton_Click;
            DestinationButton.Click += DestinationButton_Click;
            ResizeButton.Click += ResizeButton_Click;

            _controller.LoadComboBoxData(
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
            if (!_controller.PickImg())
            {
                return;
            }

            UpdatePictureBoxImage(DropPictureBox, _controller.GetImgBitmap());
            UpdateImg();
            UpdateOut();
        }

        private void DestinationButton_Click(object sender, EventArgs e)
        {
            if (_controller.PickOut())
            {
                UpdateOut();
            }
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            _controller.Resize();
        }

        private void UpdateImg()
        {
            OriginTextBox.Text = _controller.ImgPath;
        }

        private void UpdateOut()
        {
            DestinationTextBox.Text = _controller.OutPath;
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
            UpdatePictureBoxImage(ResizedPictureBox, _controller.GetOutBitmap());
        }

        private void Service_ResizeModeCrop(bool isCrop)
        {
            AnchorComboBox.Enabled = isCrop;
        }
    }
}