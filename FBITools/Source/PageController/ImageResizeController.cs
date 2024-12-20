using System;
using System.Windows.Forms;
using App.Core;
using App.Core.Desktop;
using App.Image.MagicScaler;

namespace FBITools
{
    public partial class ImageResizeController
    {
        private MagicScaler scaler;

        public ImageResizeController(ImageResizeForm page)
        {
            Page = page;
            Page.Shown += Page_Shown;
        }

        private void Page_Shown(object sender, EventArgs ev)
        {
            WarningLabel.TextChanged += WarningLabel_TextChanged;

            scaler = new MagicScaler { };

            scaler.EncoderChanged += UpdateDestination;

            scaler.InvalidFile += () =>
            {
                WarningLabel.ForeColorType = LabelType.danger;
                WarningLabel.Text = "MagicScaler Failed!";
            };

            scaler.Resized += () =>
            {
                UpdateResizedImage();

                WarningLabel.ForeColorType = LabelType.success;
                WarningLabel.Text = "MagicScaler Executed!";
            };

            scaler.EnableAnchor += (enable) => { AnchorComboBox.Enabled = enable; };

            OriginButton.Click += (s, e) =>
            {
                if (scaler.PickOrigin())
                {
                    UpdateDropImage();
                    UpdateOrigin();
                }
            };

            DestinationButton.Click += (s, e) =>
            {
                if (scaler.PickDestination())
                {
                    UpdateDestination();
                }
            };

            ResizeButton.Click += (s, e) =>
            {
                scaler.Resize().TryAwait();
            };

            CarregarCombos();
        }

        private async void WarningLabel_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            WarningLabel.Text = string.Empty;
        }

        private void CarregarCombos()
        {
            scaler.LoadEncoders(EncoderComboBox);
            scaler.LoadResizeModes(ResizeModeComboBox);
            scaler.LoadSizes(SizesComboBox);

            scaler.LoadAnchors(AnchorComboBox);
            scaler.LoadInterpolations(InterpolationComboBox);

            scaler.LoadMatteColors(MatteColorComboBox);
            scaler.LoadColorProfiles(ColorProfileComboBox);

            scaler.LoadSharpen(SharpenComboBox);
            scaler.LoadBlendingModes(BlendingModeComboBox);
            scaler.LoadHybridModes(HybridModeComboBox);

            scaler.LoadJpgQuality(JpgQualityComboBox);
            scaler.LoadJpgChromaSubsample(JpgChromaSubsampleComboBox);

            scaler.LoadPngFilters(PngFilterComboBox);
            scaler.LoadPngInterlaces(PngInterlaceComboBox);
        }

        private void UpdateOrigin()
        {
            OriginTextBox.Text = scaler.OriginPath;
        }

        private void UpdateDestination()
        {
            DestinationTextBox.Text = scaler.DestinationPath;
        }

        private void UpdateDropImage()
        {
            var imageOrigin = BitmapExtension.SuperFastLoad(scaler.OriginPath);
            DropPictureBox.Image = imageOrigin;

            if (imageOrigin.Size.Width <= DropPictureBox.Width && imageOrigin.Size.Height <= DropPictureBox.Height)
            {
                DropPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                DropPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void UpdateResizedImage()
        {
            var imageResized = BitmapExtension.SuperFastLoad(scaler.DestinationPath);
            ResizedPictureBox.Image = imageResized;

            if (imageResized.Size.Width <= ResizedPictureBox.Width && imageResized.Size.Height <= ResizedPictureBox.Height)
            {
                ResizedPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                ResizedPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}