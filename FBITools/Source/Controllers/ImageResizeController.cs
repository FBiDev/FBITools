using System;
using System.Windows.Forms;
using App.Core;
using App.Core.Desktop;
using App.Image.MagicScaler;

namespace FBITools
{
    public partial class ImageResizeController
    {
        MagicScaler Scaler;

        public ImageResizeController(ImageResizeForm formView)
        {
            form = formView;
            form.Shown += form_Shown;
        }

        void form_Shown(object sender, EventArgs ev)
        {
            lblWarning.TextChanged += lblWarning_TextChanged;

            Scaler = new MagicScaler { };

            Scaler.EncoderChanged += UpdateDestination;

            Scaler.InvalidFile += () =>
            {
                lblWarning.ForeColorType = LabelType.danger;
                lblWarning.Text = "MagicScaler Failed!";
            };

            Scaler.Resized += () =>
            {
                UpdateResizedImage();

                lblWarning.ForeColorType = LabelType.success;
                lblWarning.Text = "MagicScaler Executed!";
            };

            Scaler.EnableAnchor += (enable) => { cboAnchor.Enabled = enable; };

            btnOrigin.Click += (s, e) =>
            {
                if (Scaler.PickOrigin())
                {
                    UpdateDropImage();
                    UpdateOrigin();
                }
            };

            btnDestination.Click += (s, e) =>
            {
                if (Scaler.PickDestination())
                    UpdateDestination();
            };

            btnResize.Click += (s, e) =>
            {
                Scaler.Resize().TryAwait();
            };

            CarregarCombos();
        }

        async void lblWarning_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            lblWarning.Text = "";
        }

        void CarregarCombos()
        {
            Scaler.LoadEncoders(cboEncoder);
            Scaler.LoadResizeModes(cboResizeMode);
            Scaler.LoadSizes(cboSizes);

            Scaler.LoadAnchors(cboAnchor);
            Scaler.LoadInterpolations(cboInterpolation);

            Scaler.LoadMatteColors(cboMatteColor);
            Scaler.LoadColorProfiles(cboColorProfile);

            Scaler.LoadSharpen(cboSharpen);
            Scaler.LoadBlendingModes(cboBlendingMode);
            Scaler.LoadHybridModes(cboHybridMode);

            Scaler.LoadJpgQuality(cboJpgQuality);
            Scaler.LoadJpgChromaSubsample(cboJpgChromaSubsample);

            Scaler.LoadPngFilters(cboPngFilter);
            Scaler.LoadPngInterlaces(cboPngInterlace);
        }

        void UpdateOrigin()
        {
            txtOrigin.Text = Scaler.OriginPath;
            //Session.Options.SaveState_Origin = ImageFile.OriginPath;
        }

        void UpdateDestination()
        {
            txtDestination.Text = Scaler.DestinationPath;
            //Session.Options.SaveState_Destination = ImageFile.DestinationPath;
        }

        void UpdateDropImage()
        {
            var imageOrigin = BitmapExtension.SuperFastLoad(Scaler.OriginPath);
            picDrop.Image = imageOrigin;

            if (imageOrigin.Size.Width <= picDrop.Width && imageOrigin.Size.Height <= picDrop.Height)
                picDrop.SizeMode = PictureBoxSizeMode.CenterImage;
            else
                picDrop.SizeMode = PictureBoxSizeMode.Zoom;
        }

        void UpdateResizedImage()
        {
            var imageResized = BitmapExtension.SuperFastLoad(Scaler.DestinationPath);
            picResized.Image = imageResized;

            if (imageResized.Size.Width <= picResized.Width && imageResized.Size.Height <= picResized.Height)
                picResized.SizeMode = PictureBoxSizeMode.CenterImage;
            else
                picResized.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}