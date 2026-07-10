using System;
using System.Drawing;
using System.Windows.Forms;
using App.Core.Desktop;

namespace FBITools
{
    public partial class ImageResizeForm : ContentBaseForm
    {
        #region InitializeForm
        private readonly ImageResizeController _controller;

        public ImageResizeForm()
        {
            InitializeComponent();

            Session.ImageResizePage = this;

            Load += OnFormLoad;
            Shown += OnFormShown;

            _controller = new ImageResizeController();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
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

        private void OnFormShown(object sender, EventArgs ev)
        {
            WarningLabel.TextChanged += ClearLabelText;

            _controller.EncoderChanged += UpdateOut;
            _controller.StatusChanged += OnControllerStatusChanged;
            _controller.Resized += OnControllerResized;
            _controller.ResizeModeCrop += OnControllerResizeModeCrop;

            OriginButton.Click += OnOriginButtonClick;
            DestinationButton.Click += OnDestinationButtonClick;
            ResizeButton.Click += OnResizeButtonClick;
        }
        #endregion

        #region UserEvents
        private static async void ClearLabelText(object sender, EventArgs e)
        {
            var label = (FlatLabel)sender;
            await label.ClearTextAfterDelay(4);
        }

        private void UpdateImg()
        {
            OriginTextBox.Text = _controller.ImgPath;
        }

        private void UpdateOut()
        {
            DestinationTextBox.Text = _controller.OutPath;
        }

        private static void UpdatePictureBoxImage(FlatPictureBox pictureBox, Image image)
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

        private void OnOriginButtonClick(object sender, EventArgs e)
        {
            if (!_controller.PickImg())
            {
                return;
            }

            UpdatePictureBoxImage(DropPictureBox, _controller.GetImgBitmap());
            UpdateImg();
            UpdateOut();
        }

        private void OnDestinationButtonClick(object sender, EventArgs e)
        {
            if (_controller.PickOut())
            {
                UpdateOut();
            }
        }

        private void OnResizeButtonClick(object sender, EventArgs e)
        {
            _controller.Resize();
        }

        private void OnControllerStatusChanged(LabelType type, string message)
        {
            WarningLabel.ForeColorType = type;
            WarningLabel.Text = message;
        }

        private void OnControllerResized()
        {
            UpdatePictureBoxImage(ResizedPictureBox, _controller.GetOutBitmap());
        }

        private void OnControllerResizeModeCrop(bool isCrop)
        {
            AnchorComboBox.Enabled = isCrop;
        }
        #endregion
    }
}